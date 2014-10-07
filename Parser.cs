﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using FileModel;

namespace PASaveEditor {
    internal class Parser {
        static readonly Regex IRegex = new Regex("^\\[i \\d+\\]$", RegexOptions.Compiled);
        readonly List<string> tokens = new List<string>();


        public Prison Load(Stream stream) {
            var reader = new StreamReader(stream);
            var nodes = new Stack<Node>();
            Node currentNode = new Prison();
            int lineNum = 0;

            string line;
            while ((line = reader.ReadLine()) != null) {
                lineNum++;
                Tokenize(line);

                // skip blank lines
                if (tokens.Count == 0) continue;

                // start a new node
                if ("BEGIN".Equals(tokens[0])) {
                    nodes.Push(currentNode);

                    string label = tokens[1];
                    currentNode = currentNode.CreateNode(label);

                    if (tokens.Count > 2) {
                        // inline node
                        if (tokens.Count%2 != 1) {
                            throw new FormatException(
                                "Unexpected number of tokens in an inline node definition on line " + lineNum);
                        }
                        if (!"END".Equals(tokens[tokens.Count - 1])) {
                            throw new FormatException("Unexpected end of inline node definition on line " + lineNum);
                        }
                        for (int i = 2; i < tokens.Count - 1; i += 2) {
                            string key = tokens[i];
                            string value = tokens[i + 1];
                            currentNode.ReadKey(key, value);
                        }
                        Node upperNode = nodes.Pop();
                        upperNode.FinishedReadingNode(currentNode);
                        currentNode = upperNode;
                    } else {}

                } else if ("END".Equals(tokens[0])) {
                    // end of multi-line section
                    Node upperNode = nodes.Pop();
                    upperNode.FinishedReadingNode(currentNode);
                    currentNode = upperNode;

                } else {
                    // inside a multi-line section
                    string key = tokens[0];
                    string value = tokens[1];
                    currentNode.ReadKey(key, value);
                }
            }
            if (nodes.Count != 0) {
                throw new FormatException("Unexpected end of file!");
            }
            return (Prison)currentNode;
        }


        void Tokenize(string line) {
            tokens.Clear();
            if (line.Length == 0) {
                // If string is blank, we've got no matches. Done!
                return;
            }

            int tokenStart = 0;
            for (int i = 0; i < line.Length; i++) {
                char c = line[i];
                if (c == ' ') {
                    // eat the spaces!
                    if (tokenStart != i) {
                        tokens.Add(line.Substring(tokenStart, i - tokenStart));
                    }
                    tokenStart = i + 1;
                } else if (c == '"') {
                    // skip ahead to the next quote
                    int endQuotes = line.IndexOf('"', i + 1);
                    tokens.Add(line.Substring(i + 1, endQuotes - i - 1));
                    i = endQuotes;
                    tokenStart = i + 1;
                } else {
                    // skip ahead to the next space
                    i = line.IndexOf(' ', i) - 1;
                    if (i < 0) break;
                }
            }
            if (tokenStart < line.Length - 1) {
                // append the remainder of the string, after we ran out of spaces
                tokens.Add(line.Substring(tokenStart, line.Length - tokenStart));
            }
        }


        public static bool IsId(string str) {
            return IRegex.IsMatch(str);
        }


        public static int ParseId(string str) {
            int idxOfSpace = str.IndexOf(' ');
            string numStr = str.Substring(idxOfSpace + 1, str.Length - idxOfSpace - 2);
            return Int32.Parse(numStr);
        }
    }
}