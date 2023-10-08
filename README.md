# PrettyPrintChallenge
 Tree Algorithm, Recursion, and Printing Example with Folder Parent-Child Relationships

 A simple console application that generates a static list of Folder objects randomly ordered.
 
 The Folder objects have a name (string) and relationship to a <b>parent</b> Folder object by reference.
 Top-level folders have a "null" relationship with their parent Folder. 
 
 The application then uses a Tree algorithm to recursively navigate the list of folders and "pretty"
 print them with tab-delimited formatting based on their level in the hierarchy.
 
 Example:
<pre>
        1
            1.1
                1.1.1
                1.1.2
                1.1.3
            1.2
                1.2.1
                1.2.2
                    1.2.2.1
                    1.2.2.2
        2
            2.1
</pre>
