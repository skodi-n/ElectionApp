using System.Security.Cryptography.X509Certificates;

namespace ElectionApp;

public class Wahl
{
    private Kandidat Kandidat1;
    private Kandidat Kandidat2;
    private string _Kandidat1Name;
    private string _Kandidat2Name;
    private string _parteiKandidat1Name;
    private string _parteiKandidat2Name;
    

    public Wahl(string Kandidat1Name, string Kandidat2Name, string parteiKandidat1Name, string parteiKandidat2Name)
    {
        _Kandidat1Name = Kandidat1Name;
        _Kandidat2Name = Kandidat2Name;
        _parteiKandidat1Name = parteiKandidat1Name;
        _parteiKandidat2Name = parteiKandidat2Name;
        
        
    }
    
    
    public void KandidatHinzufuegen()
    {

        Kandidat1 = new Kandidat( _Kandidat1Name, _parteiKandidat1Name);
        Kandidat2 = new Kandidat(_Kandidat2Name, _parteiKandidat2Name);
        
    }

    public void StimmeAbgeben(string kandidateName)
    {
        if (kandidateName == "Trump")
        {

            Kandidat1.Stimmen++;


        }
        
        else if (kandidateName == "Harris")
        {
            
            Kandidat2.Stimmen++;
            
        }
        
        
    }

    public string Ergebnis()
    {
        
        if (Kandidat1.Stimmen != Kandidat2.Stimmen)
        {
            if (Kandidat1.Stimmen > Kandidat2.Stimmen)
            {
            
                return "Kandidat 1: " + Kandidat1.Name + " ,Kandidat 2: " + Kandidat2.Name + " | Stimmen Kandidat 1: " + Kandidat1.Stimmen + "  Stimmen Kandidat 2: " + Kandidat2.Stimmen + " | Winner: " + Kandidat1.Name;
            
            
            }
        
            else
            {
            
                return "Kandidat 1: " + Kandidat1.Name + " ,Kandidat 2: " + Kandidat2.Name + " | Stimmen Kandidat 1: " + Kandidat1.Stimmen + "  Stimmen Kandidat 2: " + Kandidat2.Stimmen + " | Winner: " + Kandidat2.Name;
            
            }
            
            
        }

        return "Kandidat 1: " + Kandidat1.Name + " ,Kandidat 2: " + Kandidat2.Name + " | Stimmen Kandidat 1: " + Kandidat1.Stimmen + "  Stimmen Kandidat 2: " + Kandidat2.Stimmen + " | " + "TIE!";





    }
    


}