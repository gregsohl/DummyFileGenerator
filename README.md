# DummyFileGenerator
A quick 'n dirty generator of sequentially numbered files in C#

A command line utility that will create as many files as requested.

Parameters
- Number of files (int)
- File format (text) - a .NET string format value
- Output path

Example file formats:
- file{0}.txt
- file_{0:0000}.bin

All files are populated with 1K (1024 bytes) of 0xFE
