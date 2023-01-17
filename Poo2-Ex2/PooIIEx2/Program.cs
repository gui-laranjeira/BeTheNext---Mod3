using PooIIEx2;

Smartphone motorola = new Motorola("11999220909", "Ultimo", "AS121A20", 64);
Smartphone iphone = new Iphone("11984115040", "12", "BS123A00", 128);


List<Smartphone> listaAparelhos = new();
listaAparelhos.Add(motorola);
listaAparelhos.Add(iphone);

foreach (Smartphone aparelho in listaAparelhos)
{
    aparelho.InstalarAplicativo("Whatsapp");
}