namespace ElectionApp;

public class Kandidat
{
    private string _name;
    private string _partei;
    private int _stimmen;


    public string Name
    {
        set
        {
            
            _name = value;
            
        }

        get
        {
            return _name;
            
        }
        
        
        
    }
    
    public string Partei
    {
        set
        {
            
            _partei = value;
            
        }

        get
        {
            return _partei;
            
        }
        
        
        
    }
    
    public int Stimmen
    {
        set
        {
            
            _stimmen = value;
            
        }

        get
        {
            return _stimmen;
            
        }
        
        
        
    }

    public Kandidat(string name, string partei)
    {
        Name = name;
        Partei = partei;
        Stimmen = 0;

    }
}