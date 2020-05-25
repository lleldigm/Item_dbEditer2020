using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_dbEditer2020.util
{
    public class Constant
    {
        public static readonly int LINE_MODE_NORMAL = 1;
        public static readonly int LINE_MODE_COMMENT = 2;
        public static readonly int LINE_MODE_SPACE = 3;


        public static readonly string[] LIST_TYPE = {
            "0:回復アイテム",
            "1:不明",
            "2:消費アイテム",
            "3:収集品アイテム",
            "4:防具・ペット関連",
            "5:武器",
            "6:カード",
            "7:未使用",
            "8:弓",
            "9:両手武器",
            "10:矢",
            "11:頭装備上中段",
            "12:頭装備上下段",
            "13:頭装備中下段",
            "14:頭装備上中下段",
            "15:銃",
            "16:弾丸",
            "17:苦無・手裏剣",
            "18:強化装備アイテムの箱",
            "19:キャノンボール",
            "20:コスチューム",
        };

        public static readonly string[] LIST_FILTER = {
            "全て表示",
            "回復アイテム",
            "不明",
            "消費アイテム",
            "収集品アイテム",
            "防具・ペット関連",
            "武器",
            "カード",
            "未使用",
            "弓",
            "両手武器",
            "矢",
            "頭装備上中段",
            "頭装備上下段",
            "頭装備中下段",
            "頭装備上中下段",
            "銃",
            "弾丸",
            "苦無・手裏剣",
            "強化装備アイテムの箱",
            "キャノンボール",
            "コスチューム"
        };

        public static readonly string[] LIST_SEX = {
            "0:女",
            "1:男",
            "2:全員",
            "--"
        };

    }
}
