using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;


namespace Yalamo.Helpers
{
    public class YCompressor
    {
        
        public static void Compress(string path ) {
            bool IsDirectory = ((File.GetAttributes(path) & FileAttributes.Directory) == FileAttributes.Directory);
           
            if (IsDirectory)
            {
                //compress dir
                DirectoryInfo di = new DirectoryInfo(path);
                
                foreach(FileInfo fi in di.GetFiles())
                {
                    System.Windows.Forms.MessageBox.Show(fi.FullName);
                    compresshelper(fi);
                }
            }
            else
            {
                //compress file
                FileInfo fi = new FileInfo(path);
                compresshelper(fi);
            }
        }
        public static void  Decompress( string path) 
        {
            
            FileInfo fi = new FileInfo(path);
            if(fi.Extension !=".gz"){ return ; }
            using(FileStream fs=fi.OpenRead())
            {
                //remove the extension
                string curentfilename = fi.FullName;
                string originename = curentfilename.Remove(curentfilename.Length - fi.Extension.Length);
                using(FileStream output=File.Create(originename)) 
                {
                    using(GZipStream zipStream=new GZipStream(fs,CompressionMode.Decompress))
                    {
                        CopyStream(zipStream, output);
                    }
                
                }
                
            
            }
        }
        private static void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[32768];
            while (true)
            {
                int read = input.Read(buffer, 0, buffer.Length);
                if (read <= 0) return;
                output.Write(buffer, 0, read);
            }
        }
        private static void compresshelper(FileInfo fi) 
        {
            // Get the stream of the source file.
            using (FileStream inFile = fi.OpenRead())
            {
                // Prevent compressing hidden and 
                // already compressed files.
                if ((File.GetAttributes(fi.FullName)
                    & FileAttributes.Hidden)
                    != FileAttributes.Hidden & fi.Extension != ".gz")
                {
                    // Create the compressed file.
                    using (FileStream outFile = File.Create(fi.FullName + ".gz"))
                    {
                        using (GZipStream Compress = new GZipStream(outFile, CompressionMode.Compress))
                        {
                            // Copy the source file into 
                            // the compression stream.
                            CopyStream(inFile,Compress);

                        }
                    }
                }
            }

        
        }
    
    }
}
