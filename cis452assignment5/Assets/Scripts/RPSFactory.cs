using System.Collections;
using System.Collections.Generic;

public class RPSFactory
{
    public RPS CreateRPS<TRPS>() where TRPS : RPS, new()
    {
        return new TRPS();
    }

    public RPS CreateRPS(string rpsName)
    {
        switch (rpsName)
        {
            case nameof(Rock): return new Rock(); 
            case nameof(Paper): return new Paper(); 
            case nameof(Scissors): return new Scissors(); 
            default: return null;
        }

    }
}
