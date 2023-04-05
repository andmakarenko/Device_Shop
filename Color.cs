using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device_Shop
{
    //перечисление цветов
    enum Color : uint
    {
        None = 0,
        White,
        Red,
        Green,
        Blue,
        Yellow,
        Black,
        Grey
    }

    //класс, используемый для хранения всех доступных цветов для девайса
    class Colors
    {
        public List<Color> val;

        public Colors(params Color[] colors)
        {
            this.val = new List<Color>();
            foreach (var color in colors)
            {
                if (this.val.Contains(color))
                {
                    continue;
                }
                this.val.Add(color);
            }
        }

        public override string ToString()
        {
            return $"{string.Join(", ", val)}";
        }
    }


}
