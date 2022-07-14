using cartasEspaniolas;

List<Carta>Mazo = new List<Carta>();
string[] palo = { "Espada", "Basto", "Oro", "Copa" };
for(int p= 0; p<4; p++)
{
    for(int c=0; c<12; c++)
    {
        var paloBaraja =palo[p];
        if(c==7 || c == 8)
        {
        }
        else
        {
            Carta nuevaCarta = new Carta(c+1, paloBaraja);
            Mazo.Add(nuevaCarta);   
        }
    }
}

    