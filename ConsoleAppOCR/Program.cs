// See https://aka.ms/new-console-template for more information
using Tesseract;
//Link para download tesseract windows 32 e 64 bits https://github.com/UB-Mannheim/tesseract/wiki
Console.WriteLine("Ler texto da imagem");


using (var engine = new TesseractEngine("C:\\Program Files\\Tesseract-OCR\\tessdata", "eng"))
using(var img = Pix.LoadFromFile("input.jpg"))
using(var page = engine.Process(img))
{
    var text = page.GetText();
    Console.WriteLine($"Resultado: {text}");
}