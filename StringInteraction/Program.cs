using System.Text;

string ho = "Nguyen";
string tenlot = "Thi";
string ten = "Teo";
string fullname=ho +""+ tenlot +""+ ten;
Console.WriteLine(fullname);
StringBuilder sb = new StringBuilder();
sb.Append(ho);
sb.Append(" ");
sb.Append(tenlot);
sb.Append(" ");
sb.Append(ten) ;
Console.WriteLine(sb.ToString());