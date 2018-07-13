using System;
using System.IO;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfFiles;
			Int32.TryParse(args[0], out numberOfFiles);
			string filePattern = args[1];
			string outputFolder = args[2];

			byte[] fileContent = new byte[1024];
			SetArrayContent(fileContent, 0xFE);

			for (int count = 1; count <= numberOfFiles; count++)
			{
				string fileName = string.Format(filePattern, count);
				string filePath = Path.Combine(outputFolder, fileName);
				using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
				{
					fileStream.Write(fileContent, 0, fileContent.Length);
				}
			}
		}

		private static void SetArrayContent(byte[] array, byte value)
		{
			for (int index = 0; index < array.Length; index++)
			{
				array[index] = value;
			}
		}
	}
}
