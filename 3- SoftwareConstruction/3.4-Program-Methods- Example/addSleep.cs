public int addSleep(Sleep sleep)
        {
            if (sleep != null)
            {
                sleeps.Add(sleep);
                return 1;
            }
            else 
            { 
                return -1; 
            }
        }
        public int addLibrary(Library library)
        {
            if (library != null)
            {
                libraries.Add(library);
                return 1;
            }
            else
            {
                return -1;
            }
        }
