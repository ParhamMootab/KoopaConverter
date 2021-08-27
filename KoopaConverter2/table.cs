using System;
using System.Collections.Generic;
using System.Text;

namespace KoopaConverter2
{
    public class table
    {
        

        public static double? NULL = null;
        public static List<rowInTable> populateList()
        {
            List<rowInTable> rowsList = new List<rowInTable>();
            rowsList.Add(new rowInTable(300, 80, 76, null, null, null, null, null, null, null, null, null, null, null, null, 253));
            rowsList.Add(new rowInTable(310, 85, 80.7, NULL, 43, NULL, NULL, 80.6, NULL, NULL, NULL, 74.5, 43.5, 13.5, NULL, 269));
            rowsList.Add(new rowInTable(320, 90, 85.5, NULL, 47.3, NULL, NULL, 82.8, NULL, NULL, NULL, 76, 48.5, 20.5, NULL, 286));
            rowsList.Add(new rowInTable(330, 95, 90.2, NULL, 51.3, NULL, NULL, 84.8, NULL, NULL, NULL, 77.3, 51.5, 25, NULL, 302));
            rowsList.Add(new rowInTable(340, 101, 96, NULL, 55.7, NULL, NULL, 87.2, NULL, NULL, NULL, 78.8, 53.7, 29, NULL, 322));
            rowsList.Add(new rowInTable(350, 107, 102, NULL, 59.6, NULL, NULL, 89.4, NULL, NULL, NULL, 80.1, 56.4, 33.1, NULL, 342));
            rowsList.Add(new rowInTable(360, 113, 107, NULL, 63.2, NULL, NULL, 91.4, NULL, NULL, NULL, 81.2, 58.8, 36.8, NULL, 361));
            rowsList.Add(new rowInTable(370, 120, 114, NULL, 67, NULL, NULL, 93.6, NULL, NULL, NULL, 82.4, 61.4, 40.5, NULL, 384));
            rowsList.Add(new rowInTable(380, 127, 121, NULL, 70.4, NULL, NULL, 95.7, NULL, NULL, NULL, 83.5, 63.6, 43.8, NULL, 407));
            rowsList.Add(new rowInTable(390, 134, 127, NULL, 73.4, NULL, NULL, 97.6, NULL, NULL, NULL, 84.4, 65.6, 46.6, NULL, 430));
            rowsList.Add(new rowInTable(400, 142, 135, NULL, 76.5, NULL, NULL, 99.6, NULL, NULL, NULL, 85.3, 67.6, 49.4, NULL, 456));
            rowsList.Add(new rowInTable(410, 150, 143, NULL, 79.2, 0.4, NULL, 101.4, NULL, NULL, NULL, 86.2, 69.3, 51.9, NULL, 481));
            rowsList.Add(new rowInTable(420, 158, 150, NULL, 81.6, 2.5, NULL, 103.1, NULL, NULL, NULL, 86.9, 70.9, 54.1, NULL, 507));
            rowsList.Add(new rowInTable(430, 166, 158, NULL, 83.8, 4.6, NULL, 104.7, NULL, NULL, NULL, 87.6, 72.2, 56.1, NULL, 533));
            rowsList.Add(new rowInTable(440, 175, 166, NULL, 86, 6.7, NULL, 106.3, NULL, NULL, NULL, 88.4, 73.7, 58.2, NULL, 562));
            rowsList.Add(new rowInTable(450, 183, 174, NULL, 87.8, 8.7, NULL, 107.6, NULL, NULL, NULL, 89, 74.8, 59.9, NULL, 588));
            rowsList.Add(new rowInTable(460, 192, 182, NULL, 89.7, 10.7, NULL, 109, NULL, NULL, NULL, 89.7, 76, 61.8, NULL, 616));
            rowsList.Add(new rowInTable(470, 201, 191, NULL, 91.4, 12.6, NULL, 110.2, NULL, NULL, NULL, 90.3, 77.1, 63.6, NULL, 645));
            rowsList.Add(new rowInTable(480, 211, 200, NULL, 93.3, 14.5, NULL, 111.4, NULL, NULL, NULL, 91, 78.3, 65.5, NULL, 677));
            rowsList.Add(new rowInTable(490, 220, 209, NULL, 94.9, 16.4, NULL, 112.4, NULL, NULL, NULL, 91.5, 79.2, 67.2, NULL, 706));
            rowsList.Add(new rowInTable(500, 230, 219, NULL, 96.6, 18.2, NULL, 113.4, NULL, NULL, NULL, 92, 80.2, 68.9, 33.1, 738));
            rowsList.Add(new rowInTable(510, 240, 228, 60.9, 98.3, 20.3, 40.3, 114.3, 69.8, 41.7, 19.5, 92.5, 81, 70.3, 34.5, 770));
            rowsList.Add(new rowInTable(520, 250, 238, 61.6, 99.8, 22.2, 41.8, 115.1, 70.7, 43.5, 22.4, 92.7, 81.6, 71.3, 35.7, 802));
            rowsList.Add(new rowInTable(530, 260, 247, 62.4, 101, 23.9, 43, NULL, 71.6, 44.9, 24.2, 92.8, 82, 71.9, 37, 834));
            rowsList.Add(new rowInTable(540, 271, 257, 63.1, 102, 25.6, 44.3, NULL, 72.5, 46.4, 26.1, NULL, NULL, NULL, 38.4, 869));
            rowsList.Add(new rowInTable(550, 282, 268, 63.9, 104, 27.1, 45.5, NULL, 73.4, 47.8, 28, NULL, NULL, NULL, 39.8, 904));
            rowsList.Add(new rowInTable(560, 293, 278, 64.7, 105, 28.7, 46.7, NULL, 74.3, 49.2, 29.7, NULL, NULL, NULL, 41.1, 939));
            rowsList.Add(new rowInTable(570, 304, 289, 65.4, NULL, 30.1, 47.8, NULL, 75.1, 50.6, 31.5, NULL, NULL, NULL, 42.5, 975));
            rowsList.Add(new rowInTable(580, 315, 299, 66.1, NULL, 31.5, 48.9, NULL, 75.9, 51.8, 33.1, NULL, NULL, NULL, 43.8, 1010));
            rowsList.Add(new rowInTable(590, 327, 311, 66.8, NULL, 33, 50, NULL, 76.7, 53.2, 34.9, NULL, NULL, NULL, 45.2, 1049));
            rowsList.Add(new rowInTable(600, 339, 322, 67.5, NULL, 34.5, 51.1, NULL, 77.4, 54.5, 36.6, NULL, NULL, NULL, 46.6, 1088));
            rowsList.Add(new rowInTable(610, 352, 334, 68.3, NULL, 35.9, 52.2, NULL, 78.2, 55.8, 38.3, NULL, NULL, NULL, 48.1, 1130));
            rowsList.Add(new rowInTable(620, 364, 346, 69, NULL, 37.3, 53.3, NULL, 78.9, 57, 39.9, NULL, NULL, NULL, 49.5, 1170));
            rowsList.Add(new rowInTable(630, 377, 358, 69.7, NULL, 38.6, 54.3, NULL, 79.7, 58.2, 41.5, NULL, NULL, NULL, 51, 1212));
            rowsList.Add(new rowInTable(640, 391, 371, 70.4, NULL, 40, 55.4, NULL, 80.4, 59.5, 43.1, NULL, NULL, NULL, 52.5, 1258));
            rowsList.Add(new rowInTable(650, 404, 384, 71.1, NULL, 41.3, 56.3, NULL, 81.1, 60.6, 44.6, NULL, NULL, NULL, 53.9, 1302));
            rowsList.Add(new rowInTable(660, 419, 398, 71.8, NULL, 42.6, 57.4, NULL, 81.8, 61.9, 46.3, NULL, NULL, NULL, 55.6, 1352));
            rowsList.Add(new rowInTable(670, 433, 411, 72.5, NULL, 43.9, 58.3, NULL, 82.4, 63, 47.7, NULL, NULL, NULL, 57, 1399));
            rowsList.Add(new rowInTable(680, 448, 426, 73.1, NULL, 45.1, 59.3, NULL, 83.1, 64.1, 49.2, NULL, NULL, NULL, 58.6, 1450));
            rowsList.Add(new rowInTable(690, 464, 441, 73.8, NULL, 46.4, 60.3, NULL, 83.7, 65.2, 50.7, NULL, NULL, NULL, 60.2, 1504));
            rowsList.Add(new rowInTable(700, 480, 456, 74.5, NULL, 47.6, 61.2, NULL, 84.3, 66.3, 52.2, NULL, NULL, NULL, 61.8, 1559));
            rowsList.Add(new rowInTable(710, 497, 472, 75.1, NULL, 48.9, 62.2, NULL, 84.9, 67.5, 53.7, NULL, NULL, NULL, 63.5, 1619));
            rowsList.Add(new rowInTable(720, 514, 488, 75.8, NULL, 50, 63.1, NULL, 85.5, 68.5, 55.1, NULL, NULL, NULL, 65.2, 1678));
            rowsList.Add(new rowInTable(730, 532, 505, 76.4, NULL, 51.2, 64, NULL, 86.1, 69.6, 56.5, NULL, NULL, NULL, 66.9, 1743));
            rowsList.Add(new rowInTable(740, 550, 523, 77.1, NULL, 52.4, 64.9, NULL, 86.6, 70.6, 57.8, NULL, NULL, NULL, 68.5, 1808));
            rowsList.Add(new rowInTable(750, 570, 542, 77.7, NULL, 53.5, 65.8, NULL, 87.2, 71.7, 59.2, NULL, NULL, NULL, 70.3, 1881));
            rowsList.Add(new rowInTable(760, 590, 561, 78.4, NULL, 54.7, 66.6, NULL, 87.8, 72.7, 60.5, NULL, NULL, NULL, 72.1, 1955));
            rowsList.Add(new rowInTable(770, 610, 580, 78.9, NULL, 55.8, 67.5, NULL, 88.3, 73.7, 61.8, NULL, NULL, NULL, 73.8, 2030));
            rowsList.Add(new rowInTable(780, 632, 600, 79.6, NULL, 56.9, 68.4, NULL, 88.8, 74.7, 63.1, NULL, NULL, NULL, 75.7, 2114));
            rowsList.Add(new rowInTable(790, 655, 622, 80.2, NULL, 58, 69.2, NULL, 89.3, 75.7, 64.4, NULL, NULL, NULL, 77.5, 2204));
            rowsList.Add(new rowInTable(800, 678, NULL, 80.8, NULL, 59.1, 70, NULL, 89.8, 76.7, 65.6, NULL, NULL, NULL, 79.4, NULL));
            rowsList.Add(new rowInTable(810, 703, NULL, 81.4, NULL, 60.2, 70.9, NULL, 90.3, 77.7, 66.8, NULL, NULL, NULL, 81.3, NULL));
            rowsList.Add(new rowInTable(820, 728, NULL, 81.9, NULL, 61.3, 71.7, NULL, 90.7, 78.6, 68, NULL, NULL, NULL, 83.2, NULL));
            rowsList.Add(new rowInTable(830, 755, NULL, 82.5, NULL, 62.4, 72.5, NULL, 91.2, 79.6, 69.2, NULL, NULL, NULL, 85.2, NULL));
            rowsList.Add(new rowInTable(840, 782, NULL, 83, NULL, 63.4, 73.3, NULL, 91.6, 80.5, 70.3, NULL, NULL, NULL, 87.1, NULL));
            rowsList.Add(new rowInTable(850, 811, NULL, 83.6, NULL, 64.4, 74.1, NULL, 92, 81.4, 71.4, NULL, NULL, NULL, 89.1, NULL));
            rowsList.Add(new rowInTable(860, 841, NULL, 84.1, NULL, 65.5, 74.9, NULL, 92.4, 82.2, 72.5, NULL, NULL, NULL, 91.1, NULL));
            rowsList.Add(new rowInTable(870, 873, NULL, 84.6, NULL, 66.3, 75.6, NULL, 92.7, 83, 73.5, NULL, NULL, NULL, 93.2, NULL));
            rowsList.Add(new rowInTable(890, 940, NULL, 85.6, NULL, 67.8, 76.8, NULL, 93.1, 84.3, 75.2, NULL, NULL, NULL, 97.4, NULL));
         
            return rowsList;
        }
    }
}
