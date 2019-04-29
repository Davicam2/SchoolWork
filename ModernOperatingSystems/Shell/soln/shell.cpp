#include <iostream>
#include <vector>
#include <sstream>
#include <unistd.h>
#include <fcntl.h>

#define TRUE 1

using namespace std;

// Implement pwd, cd, cat and exit.

void execute(const vector<string>& tokens) {
  // Get command. Arguments are in tokens[1...]
  string cmd = tokens[0];

  // Handle shell commands
  if (cmd == "cd") {
    if (chdir(tokens[1].c_str()) != 0) {
      cout << "Failed to change directory to " << tokens[1] << endl;
    }
  } else if (cmd == "pwd") {
    char buf[256];
    if (getcwd(buf, 256) == 0) {
      cout << "pwd failed" << endl;
    }
    cout << buf << endl;
  } else if (cmd == "cat") {
    const int fd = open(tokens[1].c_str(), O_RDONLY);
    if (fd == -1) {
      cout << "Failed to open " << tokens[1] << endl;
    } else {
      char buf[256];
      const int n = read(fd, buf, 256);
      buf[n] = 0;
      cout << buf << endl;
    }
  } else if (cmd == "exit") {
    exit(0);
  } else {
    cout << "Unknown command" << endl;
  }
}

int main() {
  // Shell loop. Press ctrl+c to exit shell.
  while (TRUE) {
    cout << "> ";

    // Get input
    string line;
    getline(cin, line);
    stringstream ss(line);
    vector<string> tokens;
    string token;
    while (ss >> token) {
      tokens.push_back(token);
    }

    // Handle the command
    execute(tokens);
  }
}
