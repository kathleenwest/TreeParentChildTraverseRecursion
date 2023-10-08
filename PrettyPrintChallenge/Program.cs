namespace PrettyPrintChallenge
{
    /// <summary>
    /// Program
    /// Simple console program that first generates a randomly ordered 
    /// list of Folders (see class) with Parent-Child relationship 
    /// references then prints out a pretty formatted and ordered 
    /// hierarchy of the folders as shown in the instructions below. 
    /// 
    /// INSTRUCTIONS: write code to pretty print the folderList     
    ///    1
    ///        1.1
    ///            1.1.1
    ///            1.1.2
    ///            1.1.3
    ///        1.2
    ///            1.2.1
    ///            1.2.2
    ///                1.2.2.1
    ///                1.2.2.2
    ///    2
    ///        2.1
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main Method
        /// Entry for console program
        /// </summary>
        /// <param name="args">Not used</param>
        static void Main(string[] args)
        {
            // Obtain a Randomly Ordered List of Folders with Parent-Child Relationship References
            List<Folder> folderList = Folder.BuildStaticFolderListRandomlyOrdered();

            // Find the Top Level Parent Folders (Ordered List)
            List<Folder> parentFolderList = folderList.Where(x => x.Parent is null).OrderBy(x => x.Name).ToList();

            // Loop Through Each Top Level Parents List and Recursively PrintChild Folders
            foreach (Folder parentFolder in parentFolderList)
            {
                // Recursively Print Self and Child Folders Starting at Level 0 (Top Level)
                Folder.PrintFolderAndChildFolders(parentFolder, 0, folderList);
            }

        } // end of main method
       
    } // end of class
} // end of namespace