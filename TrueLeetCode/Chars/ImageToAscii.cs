using System.Drawing;
using System.Text;

namespace TrueLeetCode.Chars;
public class ImageToAscii
{
    private static string[] _ascii = { "#", "#", "@", "%", "=", "+", "*", ":", "-", ".", "&nbsp;" };
    public static string AsAscii(Bitmap image)
    {
        bool toggle = false;
        var sb = new StringBuilder();

        for (int h = 0; h < image.Height; h++)
        {
            for (int w = 0; w < image.Width; w++)
            {
                var pixel = image.GetPixel(w, h);

                int r = (pixel.R + pixel.G + pixel.B) / 3;
                int g = (pixel.R + pixel.G + pixel.B) / 3;
                int b = (pixel.R + pixel.G + pixel.B) / 3;

                var gray = Color.FromArgb(r, g, b);
                if (!toggle)
                {
                    int i = gray.R * 10 / 255;
                    sb.Append(_ascii[i]);
                }
            }

            if (!toggle)
            {
                sb.Append("\n");
                toggle = true;
            }
            else
            {
                toggle = false;
            }
        }

        return sb.ToString().Replace("&nbsp;", " ");
    }
}
