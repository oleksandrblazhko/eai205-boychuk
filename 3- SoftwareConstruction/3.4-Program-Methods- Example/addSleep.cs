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

