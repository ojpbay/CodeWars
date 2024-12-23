﻿using NUnit.Framework;

namespace CodeWars
{
    public static class ElectronicsShopResult
    {
        /*
         * Complete the getMoneySpent function below.
         */
        public static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            var highestTotal = -1;
            foreach (var keyboard in keyboards)
            {
                foreach (var drive in drives)
                {
                    var total = keyboard + drive;
                    if (total <= b && total > highestTotal)
                    {
                        highestTotal = total;
                    }
                }
            }
            return highestTotal;

        }
    }

    [TestFixture]
    public class ElectronicsShopSolution
    {
        [Test]
        public void CheaperKeyboardDriveAndExpensiveDrive()
        {
            var keyboards = new int[] { 3, 1 };
            var drives = new int[] { 5, 2, 8 };
            var budget = 10;

            var result = ElectronicsShopResult.getMoneySpent(keyboards, drives, budget);

            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void CannotAffordBothKeyboardAndDrive()
        {
            var keyboards = new int[] { 4 };
            var drives = new int[] { 5 };
            var budget = 5;

            var result = ElectronicsShopResult.getMoneySpent(keyboards, drives, budget);

            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void HighestTotalDoesNotIncludeMostExpensiveKeyboardOrDrive()
        {
            var keyboards = new int[] { 183477, 732159, 779867, 598794, 596985, 156054, 445934, 156030, 99998, 58097, 459353, 866372, 333784, 601251, 142899, 708233, 651036, 20590, 56425, 970129, 722162, 832631, 938765, 212387, 779, 181866, 992436, 183446, 617621, 304311, 611791, 524875, 7068, 432043, 23068, 291295, 524893, 611991, 399952, 139526, 46677, 292211, 973975, 366445, 232824, 456173, 90627, 785353, 618526, 199719, 382549, 514351, 983453, 592549, 466869, 46461, 860135, 607682, 680461, 170563, 450601, 65067, 13268, 949100, 942415, 965850, 563416, 808580, 385504, 304683, 15970, 97695, 230946, 684388, 241080, 440252, 683418, 122066, 610135, 495289, 833383, 34397, 173404, 909526, 391149, 258839, 182278, 662672, 755532, 311782, 425252, 520186, 207989, 546834, 567829, 184897, 31321, 969804, 842475, 775308, 449856, 939711, 395240, 895029, 926868, 598035, 727436, 922082, 326615, 88513, 570573, 196028, 520952, 45238, 961389, 325404, 844725, 388765, 747489, 271411, 539814, 828925, 586884, 356834, 965473, 280998, 607171, 542819, 276062, 140956, 296341, 802378, 165305, 74568, 15640, 987110, 423497, 772419, 394971, 198761, 293555, 5524, 14083, 815646, 198888, 707017, 711503, 729172, 790354, 771445, 606097, 74062, 926510, 358547, 651224, 115896, 915166, 863298, 850231, 623439, 449552, 330973, 95432, 63573, 370902, 311053, 668992, 325257, 666073, 729771, 591431, 637702, 274784, 887413, 561370, 472322, 383014, 119622, 971931, 713406, 849106, 760957, 721893, 561404, 236039, 771141, 256127, 493907, 40443, 522851, 710823, 427638, 110916, 25425, 439436, 107916, 201765, 31437, 895966, 636554, 475478, 314427, 563403, 508686, 695673, 907771, 139363, 249349, 604554, 410476, 539963, 755722, 203107, 228850, 943066, 76998, 599001, 289817, 694942, 161258, 880667, 929908, 624495, 808303, 295701, 633547, 105519, 871657, 456638, 803854, 218490, 186613, 416604, 892761, 883480, 539464, 324419, 807623, 122116, 896294, 356379, 318076, 907033, 110077, 272194, 227987, 647837, 427205, 521, 818200, 352649, 860925, 304850, 6954, 164693, 510863, 534210, 417506, 484940, 222158, 692593, 119893, 269474, 337692, 244181, 943123, 168329, 323276, 218814, 518908, 558228, 703178, 403928, 363712, 64907, 972001, 253973, 962665, 246932, 251840, 696462, 497361, 712432, 300947, 148121, 284905, 997966, 36896, 266842, 609702, 976835, 502793, 411130, 51491, 33059, 278710, 345149, 908471, 634495, 239616, 680859, 144928, 531055, 489564, 447885, 985873, 553018, 242110, 592831, 672287, 80872, 761792, 369738, 237692, 242215, 728381, 803321, 367866, 470407, 632449, 983645, 633673, 398915, 535896, 816616, 90311, 798525, 835491, 150752, 320853, 508314, 186561, 695970, 40785, 858553, 591027, 326033, 677717, 220291, 16592, 711310, 512209, 809684, 226547, 348745, 645319, 96199, 174406, 940736, 691094, 397662, 386823, 517868, 936942, 837899, 137552, 675843, 341144, 735382, 113500, 209119, 924902, 541570, 877537, 695942, 258000, 228602, 660133, 174995, 817407, 982390, 555326, 516753, 529770, 260888, 241907, 996479, 93124, 965637, 897418, 558420, 900621, 882836, 633245, 188750, 339107, 278935, 349289, 700516, 726120, 846852, 897313, 856518, 887287, 404600, 780052, 887971, 642177, 851121, 84159, 935846, 161666, 785518, 898757, 669139, 606566, 580818, 9200, 372367, 101495, 940346, 663652, 973884, 5063, 283985, 160845, 305433, 548858, 485724, 692052, 448526, 652109, 994682, 224320, 175965, 712340, 18080, 237303, 494005, 325474, 178863, 746660, 366552, 649780, 744339, 849415, 721103, 657762, 308131, 568437, 542663, 93696, 508929, 367799, 636476, 265263, 250519, 244045, 590004, 973230, 979114, 393187, 486852, 892248, 906303, 631281, 434493, 794991, 350158, 502751, 645249, 577034, 669075, 492629, 864363, 195287, 230238, 722615, 499306, 280836, 572134, 24322, 768728, 645618, 43614, 177151, 994775, 940671, 470051, 954144, 279624, 915071, 883694, 370243, 747888, 15461, 953287, 928528, 330825, 428281, 552890, 966873, 572422, 963838, 980553, 853202, 75364, 294516, 305766, 385185, 190955, 851329, 268536, 316994, 485390, 169531, 372771, 556927, 394781, 936366, 844404, 696187, 930227, 570190, 70432, 97199, 208966, 615146, 671295, 990277, 358728, 140116, 254221, 518447, 295358, 877571, 322624, 740936, 848861, 697173, 136653, 702643, 709071, 359573, 552945, 293658, 296577, 809544, 419876, 810296, 256265, 867268, 611652, 913447, 81613, 511458, 5187, 501630, 628036, 798476, 194318, 650111, 70957, 702126, 396874, 795972, 50780, 890206, 886817, 338072, 27623, 375668, 578996, 94004, 438573, 578411, 672178, 35951, 328227, 465703, 155077, 542767, 982063, 286606, 839123, 590967, 860599, 30508, 250308, 37357, 38844, 822786, 303334, 360272, 537204, 127090, 326725, 522361, 828056, 770168, 271605, 215870, 965470, 623031, 457369, 85367, 842213, 51694, 194424, 531475, 411447, 540757, 699670, 637574, 138385, 726255, 132776, 976072, 969756, 516417, 714757, 323030, 41077, 795366, 398911, 270894, 433619, 439071, 744211, 78475, 250918, 25357, 184376, 962866, 80892, 836169, 428411, 696131, 688655, 409046, 58207, 173334, 915420, 156473, 442452, 250300, 239842, 549351, 93895, 714757, 182908, 660347, 934825, 279997, 638415, 955081, 516813, 738064, 657260, 554479, 435772, 611859, 730204, 419695, 47727, 247787, 566165, 356053, 158683, 758017, 120192, 14397, 341957, 116099, 91820, 46014, 94179, 40738, 311484, 855654, 979732, 703817, 175370, 474281, 17165, 97857, 763537, 491727, 807095, 473579, 346383, 173241, 464779, 433950, 649921, 398595, 48070, 615989, 949360, 635237, 886881, 45315, 260953, 374698, 15308, 626001, 933647, 503250, 501153, 856683, 539499, 658843, 684118, 162972, 615990, 70585, 944105, 642564, 944465, 26518, 867395, 585908, 636547, 940443, 801130, 575604, 677321, 388258, 573497, 643434, 128530, 458357, 811387, 545740, 820825, 941677, 626081, 386190, 820612, 961408, 651632, 905555, 206731, 195836, 274023, 69377, 214638, 100801, 377345, 18226, 38972, 94465, 618394, 683161, 336631, 71205, 655871, 319048, 385484, 845066, 681768, 23278, 340702, 814652, 260754, 281919, 496150, 118192, 693047, 696895, 348416, 629085, 936860, 877670, 39196, 735237, 418041, 803662, 967799, 282099, 548096, 177480, 423567, 750784, 568649, 807017, 576055, 990729, 731813, 412711, 127719, 372102, 250073, 776588, 580675, 340881, 867312, 930967, 561994, 858607, 238651, 429091, 679998, 751041, 740076, 754713, 238290 };
            var drives = new int[] { 103148, 377814, 902757, 534448, 505367, 496674, 826644, 389706, 320122, 297703, 895725, 100008, 389290, 53498, 10841, 958758, 905586, 847334, 91308, 354986, 319386, 957017, 950276, 676923, 950822, 482630, 573568, 493137, 631980, 83304, 448547, 91725, 293277, 602577, 328739, 553828, 672670, 212776, 752545, 946408, 791758, 781473, 789797, 113491, 91227, 931139, 494532, 974468, 57572, 996156, 549653, 55884, 441630, 737202, 887905, 546039, 350995, 705991, 117094, 968871, 143024, 688185, 761683, 837153, 618358, 867064, 101146, 838670, 84126, 426188, 701128, 222627, 72780, 396741, 822046, 892098, 706402, 146638, 81368, 513442, 84857, 233281, 986862, 581437, 374356, 863333, 370726, 880559, 812983, 236739, 947462, 907899, 986224, 592023, 753548, 350298, 376345, 708341, 83520, 481776, 777322, 378073, 558531, 705244, 424318, 248781, 906559, 330327, 111223, 434550, 492737, 253740, 11357, 405294, 468767, 571602, 56316, 741141, 118845, 767368, 117553, 822976, 649357, 744380, 746213, 681193, 583501, 237560, 962390, 400314, 374956, 477823, 285777, 82910, 868795, 528490, 223647, 436435, 963440, 802290, 12158, 978121, 970098, 556131, 43170, 322760, 891344, 43411, 527820, 924852, 993189, 919323, 73814, 253048, 553980, 695568, 969521, 75452, 523216, 166253, 629541, 216858, 695906, 294561, 454644, 996056, 627700, 697083, 584446, 384289, 901362, 737267, 45457, 915461, 281027, 958919, 950626, 57877, 890465, 394611, 455760, 106781, 620273, 335736, 277444, 169719, 188164, 646995, 463803, 388356, 353432, 229447, 583788, 265998, 77753, 360427, 974615, 260009, 986433, 453343, 698319, 32324, 536218, 279827, 309598, 411300, 813979, 602918, 684886, 271019, 162654, 133216, 911133, 76218, 822723, 940744, 950014, 416733, 725883, 581294, 613554, 919384, 418338, 82768, 932939, 876859, 866259, 551713, 45229, 164872, 26373, 411348, 376549, 777778, 810736, 480479, 987499, 985509, 150451, 376824, 594265, 749748, 380977, 393078, 970133, 829352, 842309, 569210, 838518, 63527, 468799, 36831, 414913, 133883, 273469, 13676, 56389, 75377, 864918, 691871, 813085, 534467, 999943, 750080, 996862, 913372, 555557, 585282, 769161, 726285, 944979, 757252, 849839, 377936, 247404, 241140, 450646, 205092, 129189, 251500, 954266, 274794, 606312, 207275, 228695, 878419, 671852, 757170, 618268, 46908, 358244, 268734, 113584, 22190, 671725, 498278, 520425, 476318, 772493, 831559, 520281, 307847, 852374, 816570, 552032, 968192, 561065, 88429, 876852, 791997, 403574, 590089, 134046, 480155, 28790, 420631, 755308, 784846, 620450, 639506, 704239, 805227, 213013, 903355, 136403, 617403, 14548, 980684, 350667, 608225, 590051, 636788, 392333, 554941, 437574, 91023, 904363, 726561, 348334, 547570, 514106, 451013, 783830, 910677, 396633, 298027, 622227, 523721, 862558, 697800, 949735, 796652, 147107, 459451, 926797, 842282, 492228, 769091, 258303, 66251, 459240, 45872, 980254, 620946, 492730, 347492, 328826, 209178, 633544, 579781, 240200, 341641, 75881, 537385, 128909, 460223, 128075, 584898, 151937, 400391, 138859, 697825, 641020, 180108, 181922, 696659, 345746, 411754, 896991, 874515, 474069, 515353, 667709, 973330, 172359, 602071, 192333, 223900, 40878, 821976, 168974, 345161, 278654, 347698, 177051, 31812, 88723, 548839, 120664, 534544, 460883, 356072, 206381, 894419, 364352, 128778, 503531, 330174, 690551, 321656, 39321, 92312, 799591, 481254, 628042, 687940, 81778, 511773, 873776, 157014, 921080, 377371, 61092, 2596, 276941, 868497, 806383, 84537, 748429, 597413, 184563, 986480, 209397, 536712, 370556, 924250, 484633, 236170, 618395, 760127, 368997, 531386, 462639, 720679, 747640, 62356, 36692, 147773, 252494, 133147, 713511, 687321, 895409, 844631, 511793, 749786, 532234, 30480, 107197, 867411, 447514, 354227, 532738, 397254, 242526, 104893, 269304, 737572, 377370, 182325, 20076, 564093, 322152, 840900, 211496, 89225, 327572, 535457, 119790, 233269, 890728, 343005, 593727, 474077, 679256, 355185, 789350, 648969, 498555, 479691, 86940, 584332, 537228, 736989, 586974, 557868, 745608, 586668, 431757, 564586, 127610, 378858, 283840, 337523, 363165, 899851, 646063, 607693, 570907, 244409, 356177, 498360, 986738, 330423, 605912, 933903, 237281, 7537, 101806, 225384, 152894, 365440, 246014, 487920, 160718, 851010, 186610, 87908, 285160, 806047, 173413, 55667, 896968, 842504, 80252, 51648, 524630, 18247, 410490, 697119, 982600, 997481, 112065, 896813, 397946, 576129, 969689, 917603, 865703, 5302, 817257, 975287, 257961, 490860, 170927, 723059, 668794, 821047, 929586, 718620, 556889, 535158, 571742, 476727, 280043, 838772, 769667, 205124, 187086, 968213, 323753, 711113, 425533, 199552, 507725, 736414, 242465, 529960, 114863, 707390, 610758, 767953, 288696, 87310, 581370, 506218, 154398, 932225, 481249, 320715, 532710, 594017, 51836, 369314, 336681, 454371, 134445, 548727, 63390, 549046, 990184, 201776, 322427, 684726, 810057, 87888, 254699, 138857, 681657, 2712, 760400, 116723, 595773, 473273, 471683, 606239, 411934, 794469, 348947, 106724, 929739, 850920, 830807, 746143, 965245, 408611, 124326, 933149, 731033, 991153, 938552, 205048, 181274, 379315, 66512, 926659, 741288, 721760, 574603, 48106, 842019, 781691, 139804, 828128, 795447, 750671, 201673, 799718, 163693, 825319, 164303, 186447, 814759, 235745, 665348, 633902, 523184, 908071, 358912, 316268, 877399, 588440, 392534, 683136, 816784, 452051, 439234, 713944, 377030, 899871, 462785, 624243, 301446, 539903, 747778, 438844, 502834, 577617, 232266, 355443, 899778, 391571, 383978, 531978, 543676, 66635, 906677, 229077, 624379, 542972, 116925, 431626, 940044, 332891, 627850, 730714, 334982, 693874, 139304, 166769, 794205, 878828, 620213, 495536, 533582, 741628, 894094, 573280, 788775, 997918, 151710, 752573, 311793, 707140, 248546, 778748, 744114, 143161, 33540, 204591, 570019, 714225, 762631, 494093, 876964, 754806, 342159, 102940, 821443, 536603, 110657, 378907, 846643, 457104, 127518, 604094, 397377, 502402, 797475, 539983, 149952, 486468, 229304, 409048, 722416, 772056, 720199, 12206, 641293, 598578, 694105, 565636, 542847, 716341, 251856, 599165, 345774, 826986, 181639, 959291, 908656, 342602, 583524, 227403, 400942, 423693, 462110, 287995, 947497, 615089, 153386, 912058, 586362, 139148, 506003, 100818, 611592, 256074, 18115, 726260, 872321, 593097, 932329, 102236, 565261, 918958, 696808, 790263, 922708, 23028, 707398, 651514, 152574, 771421, 576419, 374520, 606852, 68938, 424227, 77339, 736611, 104271, 934578, 840629, 925778, 910892, 450941, 122839, 113264, 235960, 985064, 165558, 839088, 186363, 124691, 837680, 921050, 332222, 870093, 311515, 518955, 227447, 591409, 608032, 399093, 379392, 54774, 744418, 335273, 205627, 803035, 787968, 4634, 603858, 333575, 114294, 398259, 414598, 537517, 863713, 920063, 923169, 346425, 465806, 347032, 480946, 737668, 918662, 452320, 587201, 224656, 32855, 452542, 912956, 140889, 248283, 176427, 577763, 498481, 165551, 419020, 33887, 915052, 311544, 362476, 780672, 580720, 277650, 632407, 220147, 13098, 212729, 663687, 515290, 178077, 975762, 961287, 459093, 148697, 557431, 414718, 860826, 85369, 535191, 997099, 184505, 502309, 299664, 595520, 310007, 67092, 397408, 750130, 426886, 209953, 799963, 898257, 349466, 205186, 468338, 190731, 625117, 36558, 377812, 472174, 836754, 564969, 587586, 65724, 294111, 775703, 714221, 453391, 527767, 524509, 534577, 440863, 481197, 400854, 497124, 559767, 765529, 155276, 103005, 181970, 334439, 861980, 75521, 946329, 753416, 373394, 272364, 270806, 897633, 644145, 526698, 408827, 800931, 25393, 979152, 156188 };
            var budget = 374625;

            var result = ElectronicsShopResult.getMoneySpent(keyboards, drives, budget);

            Assert.That(result, Is.EqualTo(374625));
        }

    }
}
