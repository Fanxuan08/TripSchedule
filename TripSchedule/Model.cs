using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripSchedule
{
    public class Trip
    {
        public string TripName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string MainCurrency { get; set; }
        public string PlanMode { get; set; } // "P" 或 "J"
        public List<string> Members { get; set; } = new List<string>();

        // 旅程包含的行程與帳目清單
        public List<ScheduleItem> Schedules { get; set; } = new List<ScheduleItem>();
        public List<ExpenseItem> Expenses { get; set; } = new List<ExpenseItem>();
    }

    // 2. 單一行程點 (兼容 P 模式與 J 模式)
    public class ScheduleItem
    {
        public string Day { get; set; } // 例如: "Day 1"

        // P 模式專用
        public string AreaName { get; set; }
        public string TimePeriod { get; set; } // "Morning", "Noon", "Night"
        public bool IsDone { get; set; }

        // J 模式專用
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        // 共用屬性
        public string ActivityName { get; set; }
        public string Location { get; set; }
        public string Transport { get; set; }
        public string Notes { get; set; }
    }

    // 3. 單筆記帳明細
    public class ExpenseItem
    {
        public DateTime Date { get; set; }
        public string Payer { get; set; }
        public string ItemName { get; set; }
        public string Currency { get; set; }
        public decimal OriginalAmount { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal TwdAmount { get; set; }
        public List<string> SplitMembers { get; set; } = new List<string>(); // 參與分攤的成員
    }
}
