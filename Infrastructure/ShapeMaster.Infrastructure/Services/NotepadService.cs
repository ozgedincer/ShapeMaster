using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Infrastructure.Services
{
    public class NotepadService
    {
        public void SaveToNotepad(string data)
        {

            string FolderPath = $"{DirectoryService.GetDirectory()}\\Database";
            DirectoryService.Exists(FolderPath);

            string filePath = $"{FolderPath}\\Shapes.txt";


            File.AppendAllText(filePath, $"{data}\n");
        }

    }
}