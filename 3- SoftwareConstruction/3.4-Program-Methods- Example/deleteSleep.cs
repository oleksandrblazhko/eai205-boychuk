public int deleteSleep(Sleep sleep)
{
    if (sleep != null)
    {
        sleeps.Remove(sleep);
        return 1;
    }
    else
    {
        return -1;
    }
}
