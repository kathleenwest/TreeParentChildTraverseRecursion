namespace PrettyPrintChallenge
{
    /// <summary>
    /// Folder
    /// 
    /// Properties
    /// Folder name and relationship to another folder object by reference.
    /// 
    /// Methods
    /// Builder method for returning a static list of Folder objects randomly ordered.
    /// Helper method for printing the parent and child hierarchy relationships.
    /// </summary>
    class Folder
    {
        /// <summary>
        /// Name (string)
        /// Name of the folder
        /// Example: "1" or "1.1"
        /// </summary>
        public string? Name { get; set; }
        
        /// <summary>
        /// Parent (Folder?)
        /// Parent relationship reference to this folder's parent.
        /// Examples: 
        /// Top-level: Parent = null
        /// Parent = reference to Folder object (parent)
        /// </summary>
        public Folder? Parent { get; set; }

        /// <summary>
        /// BuildStaticFolderListRandomlyOrdered()
        /// Builds and returns a static list of Folder objects
        /// that is randomly ordered.
        /// </summary>
        /// <returns>(List<Folder>) a list of Folder objects randomly ordered</returns>
        public static List<Folder> BuildStaticFolderListRandomlyOrdered()
        {
            Folder f1 = new Folder() { Name = "1", Parent = null };
            Folder f2 = new Folder() { Name = "2", Parent = null };

            Folder f1_1 = new Folder() { Name = "1.1", Parent = f1 };
            Folder f1_2 = new Folder() { Name = "1.2", Parent = f1 };

            Folder f2_1 = new Folder() { Name = "2.1", Parent = f2 };

            Folder f1_1_1 = new Folder() { Name = "1.1.1", Parent = f1_1 };
            Folder f1_1_2 = new Folder() { Name = "1.1.2", Parent = f1_1 };
            Folder f1_1_3 = new Folder() { Name = "1.1.3", Parent = f1_1 };

            Folder f1_2_1 = new Folder() { Name = "1.2.1", Parent = f1_2 };
            Folder f1_2_2 = new Folder() { Name = "1.2.2", Parent = f1_2 };

            Folder f1_2_2_1 = new Folder() { Name = "1.2.2.1", Parent = f1_2_2 };
            Folder f1_2_2_2 = new Folder() { Name = "1.2.2.2", Parent = f1_2_2 };

            Random generator = new Random();

            return (new List<Folder>()
        {
            f1,
            f1_1,
            f1_1_1,
            f1_1_2,
            f1_1_3,
            f1_2,
            f1_2_1,
            f1_2_2,
            f1_2_2_1,
            f1_2_2_2,
            f2,
            f2_1,
        }).OrderBy(x => generator.Next()).ToList();

        } // end of BuildStaticFolderListRandomlyOrdered method

        /// <summary>
        /// PrintFolderAndChildFolders
        /// This method prints the current "parent" folder with tab delimited formatting
        /// based on its current level in the hierarchy. Children of this parent folder are determined
        /// and then recursion is used to print those child folders with hierarchy. 
        /// </summary>
        /// <param name="folder">(Folder) current parent folder object</param>
        /// <param name="level">(int) level of hierarchy for tab delimited formatted printing</param>
        public static void PrintFolderAndChildFolders(Folder folder, int level, List<Folder> folderList)
        {
            // String with Tab Delimiter Repeated X Times (X = Level)
            string tabRepeatedString = new String('\t', level);

            // Pretty Prints this Parent Folder Name
            Console.WriteLine(tabRepeatedString + " " + folder.Name);

            // Find the Children of this Folder (Ordered List)
            List<Folder> childFolderList = folderList.Where(x => x.Parent == folder).OrderBy(x => x.Name).ToList();

            // Print each child of this Parent folder
            foreach (Folder child in childFolderList)
            {
                // Recursively calls the same method, incrementing the level for tab formatting
                PrintFolderAndChildFolders(child, level + 1, folderList);
            }

        } // end of PrintFolderAndChildFolders method

    } // end of class
} // end of namespace
