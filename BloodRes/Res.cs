using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodRes
{
    public class Res
    {
        [DisplayName("Код")]
        public int ID { get; set; } = 0;
        [DisplayName("Имя показателя")]
        public string Title { get; set; } = "Показатель";
        [DisplayName("Норма (мин)")]
        public double Nmin { get; set; } = 0;
        [DisplayName("Норма (макс)")]
        public double Nmax { get; set; } = 10;
        [DisplayName("Среднее")]
        public double Avg => (Nmax + Nmin) / 2;
        [DisplayName("Измерено")]
        public double Value { get; set; } = 0;
    }
}
