using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace WordGame
{
    public partial class Form1 : Form
    {
        static Image AGrey = WordGame.Properties.Resources.A_GREY;
        static Image BGrey = WordGame.Properties.Resources.B_GREY;
        static Image CGrey = WordGame.Properties.Resources.C_GREY;
        static Image DGrey = WordGame.Properties.Resources.D_GREY;
        static Image EGrey = WordGame.Properties.Resources.E_GREY;
        static Image FGrey = WordGame.Properties.Resources.F_GREY;
        static Image GGrey = WordGame.Properties.Resources.G_GREY;
        static Image HGrey = WordGame.Properties.Resources.H_GREY;
        static Image IGrey = WordGame.Properties.Resources.I_GREY;
        static Image JGrey = WordGame.Properties.Resources.J_GREY;
        static Image KGrey = WordGame.Properties.Resources.K_GREY;
        static Image LGrey = WordGame.Properties.Resources.L_GREY;
        static Image MGrey = WordGame.Properties.Resources.M_GREY;
        static Image NGrey = WordGame.Properties.Resources.N_GREY;
        static Image OGrey = WordGame.Properties.Resources.O_GREY;
        static Image PGrey = WordGame.Properties.Resources.P_GREY;
        static Image QGrey = WordGame.Properties.Resources.Q_GREY;
        static Image RGrey = WordGame.Properties.Resources.R_GREY;
        static Image SGrey = WordGame.Properties.Resources.S_GREY;
        static Image TGrey = WordGame.Properties.Resources.T_GREY;
        static Image UGrey = WordGame.Properties.Resources.U_GREY;
        static Image VGrey = WordGame.Properties.Resources.V_GREY;
        static Image WGrey = WordGame.Properties.Resources.W_GREY;
        static Image XGrey = WordGame.Properties.Resources.X_GREY;
        static Image YGrey = WordGame.Properties.Resources.Y_GREY;
        static Image ZGrey = WordGame.Properties.Resources.Z_GREY;
        static Image Emp = WordGame.Properties.Resources.PLACEHOLDER;
        static Image AYellow = WordGame.Properties.Resources.A_YELLOW;
        static Image BYellow = WordGame.Properties.Resources.B_YELLOW;
        static Image CYellow = WordGame.Properties.Resources.C_YELLOW;
        static Image DYellow = WordGame.Properties.Resources.D_YELLOW;
        static Image EYellow = WordGame.Properties.Resources.E_YELLOW;
        static Image FYellow = WordGame.Properties.Resources.F_YELLOW;
        static Image GYellow = WordGame.Properties.Resources.G_YELLOW;
        static Image HYellow = WordGame.Properties.Resources.H_YELLOW;
        static Image IYellow = WordGame.Properties.Resources.I_YELLOW;
        static Image JYellow = WordGame.Properties.Resources.J_YELLOW;
        static Image KYellow = WordGame.Properties.Resources.K_YELLOW;
        static Image LYellow = WordGame.Properties.Resources.L_YELLOW;
        static Image MYellow = WordGame.Properties.Resources.M_YELLOW;
        static Image NYellow = WordGame.Properties.Resources.N_YELLOW;
        static Image OYellow = WordGame.Properties.Resources.O_YELLOW;
        static Image PYellow = WordGame.Properties.Resources.P_YELLOW;
        static Image QYellow = WordGame.Properties.Resources.Q_YELLOW;
        static Image RYellow = WordGame.Properties.Resources.R_YELLOW;
        static Image SYellow = WordGame.Properties.Resources.S_YELLOW;
        static Image TYellow = WordGame.Properties.Resources.T_YELLOW;
        static Image UYellow = WordGame.Properties.Resources.U_YELLOW;
        static Image VYellow = WordGame.Properties.Resources.V_YELLOW;
        static Image WYellow = WordGame.Properties.Resources.W_YELLOW;
        static Image XYellow = WordGame.Properties.Resources.X_YELLOW;
        static Image YYellow = WordGame.Properties.Resources.Y_YELLOW;
        static Image ZYellow = WordGame.Properties.Resources.Z_YELLOW;
        static Image AGreen = WordGame.Properties.Resources.A_GREEN;
        static Image BGreen = WordGame.Properties.Resources.B_GREEN;
        static Image CGreen = WordGame.Properties.Resources.C_GREEN;
        static Image DGreen = WordGame.Properties.Resources.D_GREEN;
        static Image EGreen = WordGame.Properties.Resources.E_GREEN;
        static Image FGreen = WordGame.Properties.Resources.F_GREEN;
        static Image GGreen = WordGame.Properties.Resources.G_GREEN;
        static Image HGreen = WordGame.Properties.Resources.H_GREEN;
        static Image IGreen = WordGame.Properties.Resources.I_GREEN;
        static Image JGreen = WordGame.Properties.Resources.J_GREEN;
        static Image KGreen = WordGame.Properties.Resources.K_GREEN;
        static Image LGreen = WordGame.Properties.Resources.L_GREEN;
        static Image MGreen = WordGame.Properties.Resources.M_GREEN;
        static Image NGreen = WordGame.Properties.Resources.N_GREEN;
        static Image OGreen = WordGame.Properties.Resources.O_GREEN;
        static Image PGreen = WordGame.Properties.Resources.P_GREEN;
        static Image QGreen = WordGame.Properties.Resources.Q_GREEN;
        static Image RGreen = WordGame.Properties.Resources.R_GREEN;
        static Image SGreen = WordGame.Properties.Resources.S_GREEN;
        static Image TGreen = WordGame.Properties.Resources.T_GREEN;
        static Image UGreen = WordGame.Properties.Resources.U_GREEN;
        static Image VGreen = WordGame.Properties.Resources.V_GREEN;
        static Image WGreen = WordGame.Properties.Resources.W_GREEN;
        static Image XGreen = WordGame.Properties.Resources.X_GREEN;
        static Image YGreen = WordGame.Properties.Resources.Y_GREEN;
        static Image ZGreen = WordGame.Properties.Resources.Z_GREEN;
        static string stringWords = Properties.Resources.sgb_words;

        int i = 1;
        int i2;
        int x = 1;
        int letter1 = 26;
        int letter2 = 26;
        int letter3 = 26;
        int letter4 = 26;
        int letter5 = 26;
        int ranWord;
        int letterNum;
        int list = 0;
        int wrongCheck;

        char stringLetter1;
        char stringLetter2;
        char stringLetter3;
        char stringLetter4;
        char stringLetter5;
        string fullString = null;

        Random rnd = new Random();
        //Grey ranges from 0-25
        //Yellow ranges from 27-52
        //Green ranges from 53-78
        Image[] Letters = new Image[] { AGrey, BGrey, CGrey, DGrey, EGrey, FGrey, GGrey, HGrey, IGrey, JGrey, KGrey, LGrey, MGrey, NGrey, OGrey, PGrey, QGrey, RGrey, SGrey, TGrey, UGrey, VGrey, WGrey, XGrey, YGrey, ZGrey, Emp, AYellow, BYellow, CYellow, DYellow, EYellow, FYellow, GYellow, HYellow, IYellow, JYellow, KYellow, LYellow, MYellow, NYellow, OYellow, PYellow, QYellow, RYellow, SYellow, TYellow, UYellow, VYellow, WYellow, XYellow, YYellow, ZYellow, AGreen, BGreen, CGreen, DGreen, EGreen, FGreen, GGreen, HGreen, IGreen, JGreen, KGreen, LGreen, MGreen, NGreen, OGreen, PGreen, QGreen, RGreen, SGreen, TGreen, UGreen, VGreen, WGreen, XGreen, YGreen, ZGreen };
        string[] words = new string[] { "about", "above", "abuse", "actor", "acute", "admit", "adopt", "adult", "after", "again", "agent", "agree", "ahead", "alarm", "album", "alert", "alike", "alive", "allow", "alone", "along", "alter", "among", "anger", "angle", "angry", "apart", "apple", "apply", "arena", "argue", "arise", "array", "aside", "asset", "audio", "audit", "avoid", "award", "aware", "badly", "baker", "bases", "basic", "basis", "beach", "began", "begin", "begun", "being", "below", "bench", "billy", "birth", "black", "blame", "blind", "block", "blood", "board", "boost", "buyer", "china", "cover", "booth", "cable", "chose", "craft", "bound", "calif", "civil", "crash", "brain", "carry", "claim", "cream", "brand", "catch", "class", "crime", "bread", "cause", "clean", "cross", "break", "chain", "clear", "crowd", "breed", "chair", "click", "crown", "brief", "chart", "clock", "curve", "bring", "chase", "close", "cycle", "broad", "cheap", "coach", "daily", "broke", "check", "coast", "dance", "brown", "chest", "could", "dated", "build", "chief", "count", "dealt", "built", "child", "court", "death", "debut", "entry", "forth", "group", "delay", "equal", "forty", "grown", "depth", "error", "forum", "guard", "doing", "event", "found", "guess", "doubt", "every", "frame", "guest", "dozen", "exact", "frank", "guide", "draft", "exist", "fraud", "happy", "drama", "extra", "fresh", "harry", "drawn", "faith", "front", "heart", "dream", "false", "fruit", "heavy", "dress", "fault", "fully", "hence", "drill", "fibre", "funny", "night", "drink", "field", "giant", "horse", "drive", "fifth", "given", "hotel", "drove", "fifty", "glass", "house", "dying", "fight", "globe", "human", "eager", "final", "going", "ideal", "early", "first", "grace", "image", "earth", "fixed", "grade", "index", "eight", "flash", "grand", "inner", "elite", "fleet", "grant", "input", "empty", "floor", "grass", "issue", "enemy", "fluid", "great", "irony", "enjoy", "focus", "green", "juice", "enter", "force", "gross", "joint", "judge", "metal", "media", "newly", "known", "local", "might", "noise", "label", "logic", "minor", "north", "large", "loose", "minus", "noted", "laser", "lower", "mixed", "novel", "later", "lucky", "model", "nurse", "laugh", "lunch", "money", "occur", "layer", "lying", "loyal", "ledge", "month", "ocean", "onion", "learn", "magic", "moral", "offer", "lease", "major", "motor", "often", "least", "maker", "mount", "order", "leave", "march", "mouse", "other", "legal", "music", "mouth", "ought", "level", "match", "movie", "paint", "light", "mayor", "needs", "paper", "limit", "meant", "never", "party", "peace", "power", "radio", "round", "panel", "press", "raise", "route", "phase", "price", "range", "royal", "phone", "pride", "rapid", "rural", "photo", "prime", "ratio", "scale", "piece", "print", "reach", "scene", "pilot", "prior", "ready", "scope", "pitch", "prize", "refer", "score", "place", "proof", "right", "sense", "plain", "proud", "rival", "serve", "plane", "prove", "river", "seven", "plant", "queen", "quick", "shall", "plate", "sixth", "stand", "shape", "point", "quiet", "roman", "share", "pound", "quite", "rough", "sharp", "sheet", "spare", "style", "times", "shelf", "speak", "sugar", "tired", "shell", "speed", "suite", "title", "shift", "spend", "super", "today", "shirt", "spent", "sweet", "topic", "shock", "split", "table", "total", "shoot", "spoke", "taken", "touch", "short", "sport", "taste", "tough", "shown", "staff", "taxes", "tower", "sight", "stage", "teach", "track", "since", "stake", "teeth", "trade", "sixty", "start", "texas", "treat", "sized", "state", "thank", "trend", "skill", "steam", "theft", "trial", "sleep", "steel", "their", "tried", "slide", "stick", "theme", "tries", "small", "still", "there", "truck", "smart", "stock", "these", "truly", "smile", "stone", "thick", "trust", "smith", "stood", "thing", "truth", "smoke", "store", "think", "twice", "solid", "storm", "third", "under", "solve", "story", "those", "undue", "sorry", "strip", "three", "union", "sound", "stuck", "threw", "unity", "south", "study", "throw", "until", "space", "stuff", "tight", "upper", "upset", "whole", "waste", "wound", "urban", "whose", "watch", "write", "usage", "woman", "water", "wrong", "usual", "train", "wheel", "wrote", "valid", "world", "where", "yield", "value", "worry", "which", "young", "video", "worse", "while", "youth", "virus", "worst", "white", "worth", "visit", "would", "vital", "voice" };
        public Form1()
        {
            InitializeComponent();
            ranWord = rnd.Next(words.Length);
        }

        private void pictureBox36_Click(object sender, EventArgs e) //Button A
        {
            letterNum = 0;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox49_Click(object sender, EventArgs e) //Button B
        {
            letterNum = 1;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox47_Click(object sender, EventArgs e) //Button C
        {
            letterNum = 2;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox38_Click(object sender, EventArgs e) //Button D
        {
            letterNum = 3;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox28_Click(object sender, EventArgs e) //Button E
        {
            letterNum = 4;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox39_Click(object sender, EventArgs e) //Button F
        {
            letterNum = 5;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox40_Click(object sender, EventArgs e) //Button G
        {
            letterNum = 6;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox41_Click(object sender, EventArgs e) //Button H
        {
            letterNum = 7;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox33_Click(object sender, EventArgs e) //Button I
        {
            letterNum = 8;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox42_Click(object sender, EventArgs e) //Button J
        {
            letterNum = 9;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox43_Click(object sender, EventArgs e) //Button K
        {
            letterNum = 10;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox44_Click(object sender, EventArgs e) //Button L
        {
            letterNum = 11;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox51_Click(object sender, EventArgs e) //Button M
        {
            letterNum = 12;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox50_Click(object sender, EventArgs e) //Button N
        {
            letterNum = 13;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox34_Click(object sender, EventArgs e) //Button O
        {
            letterNum = 14;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox35_Click(object sender, EventArgs e) //Button P
        {
            letterNum = 15;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox26_Click(object sender, EventArgs e) //Button Q
        {
            letterNum = 16;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox29_Click(object sender, EventArgs e) //Button R
        {
            letterNum = 17;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox37_Click(object sender, EventArgs e) //Button S
        {
            letterNum = 18;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox30_Click(object sender, EventArgs e) //Button T
        {
            letterNum = 19;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox32_Click(object sender, EventArgs e) //Button U
        {
            letterNum = 20;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox48_Click(object sender, EventArgs e) //Button V
        {
            letterNum = 21;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox27_Click(object sender, EventArgs e) //Button W
        {
            letterNum = 22;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox46_Click(object sender, EventArgs e) //Button X
        {
            letterNum = 23;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox31_Click(object sender, EventArgs e) //Button Y
        {
            letterNum = 24;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox45_Click(object sender, EventArgs e) //Button Z
        {
            letterNum = 25;
            TypeLetter(ref letter1, ref letter2, ref letter3, ref letter4, ref letter5, ref i, ref x, letterNum);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter1], 0, 0, 84, 84);
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter2], 0, 0, 84, 84);
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter3], 0, 0, 84, 84);
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter4], 0, 0, 84, 84);
        }

        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter5], 0, 0, 84, 84);
        }

        private void pictureBox10_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter1], 0, 0, 84, 84);
        }

        private void pictureBox9_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter2], 0, 0, 84, 84);
        }

        private void pictureBox8_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter3], 0, 0, 84, 84);
        }

        private void pictureBox7_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter4], 0, 0, 84, 84);
        }

        private void pictureBox6_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter5], 0, 0, 84, 84);
        }

        private void TypeLetter(ref int letter1, ref int letter2, ref int letter3, ref int letter4, ref int letter5, ref int i, ref int x, int letterNum)
        {
            //Row 1
            if (i == 1 && x == 1)
            {
                letter1 = letterNum;
                pictureBox1.Refresh();
                pictureBox1.Update();
                i++;
            } 
            else if (i == 2 && x == 1)
            {
                letter2 = letterNum;
                pictureBox2.Refresh();
                pictureBox2.Update();
                i++;
            }
            else if (i == 3 && x == 1)
            {
                letter3 = letterNum;
                pictureBox3.Refresh();
                pictureBox3.Update();
                i++;
            }
            else if (i == 4 && x == 1)
            {
                letter4 = letterNum;
                pictureBox4.Refresh();
                pictureBox4.Update();
                i++;
            }
            else if (i == 5 && x == 1)
            {
                letter5 = letterNum;
                pictureBox5.Refresh();
                pictureBox5.Update();
                i++;
            }
            //Row 2
            else if (i == 1 && x == 2)
            {
                letter1 = letterNum;
                pictureBox10.Refresh();
                pictureBox10.Update();
                i++;
            } 
            else if (i == 2 && x == 2)
            {
                letter2 = letterNum;
                pictureBox9.Refresh();
                pictureBox9.Update();
                i++;
            }
            else if (i == 3 && x == 2)
            {
                letter3 = letterNum;
                pictureBox8.Refresh();
                pictureBox8.Update();
                i++;
            }
            else if (i == 4 && x == 2)
            {
                letter4 = letterNum;
                pictureBox7.Refresh();
                pictureBox7.Update();
                i++;
            }
            else if (i == 5 && x == 2)
            {
                letter5 = letterNum;
                pictureBox6.Refresh();
                pictureBox6.Update();
                i++;
            }
            //Row 3
            else if (i == 1 && x == 3)
            {
                letter1 = letterNum;
                pictureBox15.Refresh();
                pictureBox15.Update();
                i++;
            }
            else if (i == 2 && x == 3)
            {
                letter2 = letterNum;
                pictureBox14.Refresh();
                pictureBox14.Update();
                i++;
            }
            else if (i == 3 && x == 3)
            {
                letter3 = letterNum;
                pictureBox13.Refresh();
                pictureBox13.Update();
                i++;
            }
            else if (i == 4 && x == 3)
            {
                letter4 = letterNum;
                pictureBox12.Refresh();
                pictureBox12.Update();
                i++;
            }
            else if (i == 5 && x == 3)
            {
                letter5 = letterNum;
                pictureBox11.Refresh();
                pictureBox11.Update();
                i++;
            }
            //Row 4
            else if (i == 1 && x == 4)
            {
                letter1 = letterNum;
                pictureBox20.Refresh();
                pictureBox15.Update();
                i++;
            }
            else if (i == 2 && x == 4)
            {
                letter2 = letterNum;
                pictureBox19.Refresh();
                pictureBox19.Update();
                i++;
            }
            else if (i == 3 && x == 4)
            {
                letter3 = letterNum;
                pictureBox18.Refresh();
                pictureBox18.Update();
                i++;
            }
            else if (i == 4 && x == 4)
            {
                letter4 = letterNum;
                pictureBox17.Refresh();
                pictureBox17.Update();
                i++;
            }
            else if (i == 5 && x == 4)
            {
                letter5 = letterNum;
                pictureBox16.Refresh();
                pictureBox16.Update();
                i++;
            }
            //Row 5
            else if (i == 1 && x == 5)
            {
                letter1 = letterNum;
                pictureBox25.Refresh();
                pictureBox25.Update();
                i++;
            }
            else if (i == 2 && x == 5)
            {
                letter2 = letterNum;
                pictureBox24.Refresh();
                pictureBox24.Update();
                i++;
            }
            else if (i == 3 && x == 5)
            {
                letter3 = letterNum;
                pictureBox23.Refresh();
                pictureBox23.Update();
                i++;
            }
            else if (i == 4 && x == 5)
            {
                letter4 = letterNum;
                pictureBox22.Refresh();
                pictureBox22.Update();
                i++;
            }
            else if (i == 5 && x == 5)
            {
                letter5 = letterNum;
                pictureBox21.Refresh();
                pictureBox21.Update();
                i++;
            }
        } //Type Function

        private void pictureBox15_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter1], 0, 0, 84, 84);
        }

        private void pictureBox14_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter2], 0, 0, 84, 84);
        }

        private void pictureBox13_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter3], 0, 0, 84, 84);
        }

        private void pictureBox12_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter4], 0, 0, 84, 84);
        }

        private void pictureBox11_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter5], 0, 0, 84, 84);
        }

        private void pictureBox20_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter1], 0, 0, 84, 84);
        }

        private void pictureBox19_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter2], 0, 0, 84, 84);
        }

        private void pictureBox18_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter3], 0, 0, 84, 84);
        }

        private void pictureBox17_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter4], 0, 0, 84, 84);
        }

        private void pictureBox16_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter5], 0, 0, 84, 84);
        }

        private void pictureBox25_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter1], 0, 0, 84, 84);
        }

        private void pictureBox24_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter2], 0, 0, 84, 84);
        }

        private void pictureBox23_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter3], 0, 0, 84, 84);
        }

        private void pictureBox22_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter4], 0, 0, 84, 84);
        }

        private void pictureBox21_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Letters[letter5], 0, 0, 84, 84);
        }

        private void pictureBox53_Click(object sender, EventArgs e) //Enter Button
        {
            //Grey ranges from 0-25
            //Yellow ranges from 27-52
            //Green ranges from 53-78
            if (letter5 != 26)
            {
                stringLetter1 = (char)(letter1 + 97);
                stringLetter2 = (char)(letter2 + 97);
                stringLetter3 = (char)(letter3 + 97);
                stringLetter4 = (char)(letter4 + 97);
                stringLetter5 = (char)(letter5 + 97);
                fullString = stringLetter1.ToString() + stringLetter2.ToString() + stringLetter3.ToString() + stringLetter4.ToString() + stringLetter5.ToString();

                for (i2 = 0; i2 < words.Length; i2++)
                {
                    if (fullString == words[i2])
                    {
                        i = 1;

                        //Yellow Letters
                        if ((stringLetter1.ToString() == words[ranWord].Substring(1, 1) && stringLetter2.ToString() != words[ranWord].Substring(1, 1)) || (stringLetter1.ToString() == words[ranWord].Substring(2, 1) && stringLetter3.ToString() != words[ranWord].Substring(2, 1)) || (stringLetter1.ToString() == words[ranWord].Substring(3, 1) && stringLetter4.ToString() != words[ranWord].Substring(3, 1)) || (stringLetter1.ToString() == words[ranWord].Substring(4, 1) && stringLetter5.ToString() != words[ranWord].Substring(4, 1)))
                        {
                            letter1 += 27;
                            if (x == 1) { pictureBox1.Refresh(); pictureBox1.Update(); }
                            if (x == 2) { pictureBox10.Refresh(); pictureBox10.Update(); }
                            if (x == 3) { pictureBox15.Refresh(); pictureBox15.Update(); }
                            if (x == 4) { pictureBox20.Refresh(); pictureBox20.Update(); }
                            if (x == 5) { pictureBox25.Refresh(); pictureBox25.Update(); }
                            letter1 -= 27;
                        }

                        if ((stringLetter2.ToString() == words[ranWord].Substring(0, 1) && stringLetter1.ToString() != words[ranWord].Substring(0, 1)) || (stringLetter2.ToString() == words[ranWord].Substring(2, 1) && stringLetter3.ToString() != words[ranWord].Substring(2, 1)) || (stringLetter2.ToString() == words[ranWord].Substring(3, 1) && stringLetter4.ToString() != words[ranWord].Substring(3, 1)) || (stringLetter2.ToString() == words[ranWord].Substring(4, 1) && stringLetter5.ToString() != words[ranWord].Substring(4, 1)))
                        {
                            letter2 += 27;
                            if (x == 1) { pictureBox2.Refresh(); pictureBox2.Update(); }
                            if (x == 2) { pictureBox9.Refresh(); pictureBox9.Update(); }
                            if (x == 3) { pictureBox14.Refresh(); pictureBox14.Update(); }
                            if (x == 4) { pictureBox19.Refresh(); pictureBox19.Update(); }
                            if (x == 5) { pictureBox24.Refresh(); pictureBox24.Update(); }
                            letter2 -= 27;
                        }

                        if ((stringLetter3.ToString() == words[ranWord].Substring(0, 1) && stringLetter1.ToString() != words[ranWord].Substring(0, 1)) || (stringLetter3.ToString() == words[ranWord].Substring(1, 1) && stringLetter2.ToString() != words[ranWord].Substring(1, 1)) || (stringLetter3.ToString() == words[ranWord].Substring(3, 1) && stringLetter4.ToString() != words[ranWord].Substring(3, 1)) || (stringLetter3.ToString() == words[ranWord].Substring(4, 1) && stringLetter5.ToString() != words[ranWord].Substring(4, 1)))
                        {
                            letter3 += 27;
                            if (x == 1) { pictureBox3.Refresh(); pictureBox3.Update(); }
                            if (x == 2) { pictureBox8.Refresh(); pictureBox8.Update(); }
                            if (x == 3) { pictureBox13.Refresh(); pictureBox13.Update(); }
                            if (x == 4) { pictureBox18.Refresh(); pictureBox18.Update(); }
                            if (x == 5) { pictureBox23.Refresh(); pictureBox23.Update(); }
                            letter3 -= 27;
                        }

                        if ((stringLetter4.ToString() == words[ranWord].Substring(0, 1) && stringLetter1.ToString() != words[ranWord].Substring(0, 1)) || (stringLetter4.ToString() == words[ranWord].Substring(1, 1) && stringLetter2.ToString() != words[ranWord].Substring(1, 1)) || (stringLetter4.ToString() == words[ranWord].Substring(2, 1) && stringLetter3.ToString() != words[ranWord].Substring(2, 1)) || (stringLetter4.ToString() == words[ranWord].Substring(4, 1) && stringLetter5.ToString() != words[ranWord].Substring(4, 1)))
                        {
                            letter4 += 27;
                            if (x == 1) { pictureBox4.Refresh(); pictureBox4.Update(); }
                            if (x == 2) { pictureBox7.Refresh(); pictureBox7.Update(); }
                            if (x == 3) { pictureBox12.Refresh(); pictureBox12.Update(); }
                            if (x == 4) { pictureBox17.Refresh(); pictureBox17.Update(); }
                            if (x == 5) { pictureBox22.Refresh(); pictureBox22.Update(); }
                            letter4 -= 27;
                        }

                        if ((stringLetter5.ToString() == words[ranWord].Substring(0, 1) && stringLetter1.ToString() != words[ranWord].Substring(0, 1)) || (stringLetter5.ToString() == words[ranWord].Substring(1, 1) && stringLetter2.ToString() != words[ranWord].Substring(1, 1)) || (stringLetter5.ToString() == words[ranWord].Substring(2, 1) && stringLetter3.ToString() != words[ranWord].Substring(2, 1)) || (stringLetter5.ToString() == words[ranWord].Substring(3, 1) && stringLetter4.ToString() != words[ranWord].Substring(3, 1)))
                        {
                            letter5 += 27;
                            if (x == 1) { pictureBox5.Refresh(); pictureBox5.Update(); }
                            if (x == 2) { pictureBox6.Refresh(); pictureBox6.Update(); }
                            if (x == 3) { pictureBox11.Refresh(); pictureBox11.Update(); }
                            if (x == 4) { pictureBox16.Refresh(); pictureBox16.Update(); }
                            if (x == 5) { pictureBox21.Refresh(); pictureBox21.Update(); }
                            letter5 -= 27;
                        }

                        //Green Letters
                        if (stringLetter1.ToString() == words[ranWord].Substring(0, 1))
                        {
                            letter1 += 53;
                            if (x == 1) { pictureBox1.Refresh(); pictureBox1.Update(); }
                            if (x == 2) { pictureBox10.Refresh(); pictureBox10.Update(); }
                            if (x == 3) { pictureBox15.Refresh(); pictureBox15.Update(); }
                            if (x == 4) { pictureBox20.Refresh(); pictureBox20.Update(); }
                            if (x == 5) { pictureBox25.Refresh(); pictureBox25.Update(); }
                        }

                        if (stringLetter2.ToString() == words[ranWord].Substring(1, 1))
                        {
                            letter2 += 53;
                            if (x == 1) { pictureBox2.Refresh(); pictureBox2.Update(); }
                            if (x == 2) { pictureBox9.Refresh(); pictureBox9.Update(); }
                            if (x == 3) { pictureBox14.Refresh(); pictureBox14.Update(); }
                            if (x == 4) { pictureBox19.Refresh(); pictureBox19.Update(); }
                            if (x == 5) { pictureBox24.Refresh(); pictureBox24.Update(); }
                        }

                        if (stringLetter3.ToString() == words[ranWord].Substring(2, 1))
                        {
                            letter3 += 53;
                            if (x == 1) { pictureBox3.Refresh(); pictureBox3.Update(); }
                            if (x == 2) { pictureBox8.Refresh(); pictureBox8.Update(); }
                            if (x == 3) { pictureBox13.Refresh(); pictureBox13.Update(); }
                            if (x == 4) { pictureBox18.Refresh(); pictureBox18.Update(); }
                            if (x == 5) { pictureBox23.Refresh(); pictureBox23.Update(); }
                        }

                        if (stringLetter4.ToString() == words[ranWord].Substring(3, 1))
                        {
                            letter4 += 53;
                            if (x == 1) { pictureBox4.Refresh(); pictureBox4.Update(); }
                            if (x == 2) { pictureBox7.Refresh(); pictureBox7.Update(); }
                            if (x == 3) { pictureBox12.Refresh(); pictureBox12.Update(); }
                            if (x == 4) { pictureBox17.Refresh(); pictureBox17.Update(); }
                            if (x == 5) { pictureBox22.Refresh(); pictureBox22.Update(); }
                        }

                        if (stringLetter5.ToString() == words[ranWord].Substring(4, 1))
                        {
                            letter5 += 53;
                            if (x == 1) { pictureBox5.Refresh(); pictureBox5.Update(); }
                            if (x == 2) { pictureBox6.Refresh(); pictureBox6.Update(); }
                            if (x == 3) { pictureBox11.Refresh(); pictureBox11.Update(); }
                            if (x == 4) { pictureBox16.Refresh(); pictureBox16.Update(); }
                            if (x == 5) { pictureBox21.Refresh(); pictureBox21.Update(); }
                        }

                        if (fullString == words[ranWord]) //{ pictureBox25.Refresh(); pictureBox25.Update(); } //Test to see if random word is found from array
                        {
                            MessageBox.Show("You Win!");
                            x+= 10;
                        }
                        else { x++; }

                        letter1 = 26;
                        letter2 = 26;
                        letter3 = 26;
                        letter4 = 26;
                        letter5 = 26;
                    }
                    else { wrongCheck += 1; }
                }
                if (wrongCheck == words.Length && fullString != words[ranWord]) { MessageBox.Show("That word is not in the word list!"); }
                wrongCheck = 0;
            }
        }

        private void pictureBox52_Click(object sender, EventArgs e) //Backspace Button
        {
            //Row 1
            if (i == 2 && x == 1)
            {
                letter1 = 26;
                i--;
                pictureBox1.Refresh();
                pictureBox1.Update();
            }
            if (i == 3 && x == 1)
            {
                letter2 = 26;
                i--;
                pictureBox2.Refresh();
                pictureBox2.Update();
            }
            if (i == 4 && x == 1)
            {
                letter3 = 26;
                i--;
                pictureBox3.Refresh();
                pictureBox3.Update();
            }
            if (i == 5 && x == 1)
            {
                letter4 = 26;
                i--;
                pictureBox4.Refresh();
                pictureBox4.Update();
            }
            if (i == 6 && x == 1)
            {
                letter5 = 26;
                i--;
                pictureBox5.Refresh();
                pictureBox5.Update();
            }

            //Row 2
            if (i == 2 && x == 2)
            {
                letter1 = 26;
                i--;
                pictureBox10.Refresh();
                pictureBox10.Update();
            }
            if (i == 3 && x == 2)
            {
                letter2 = 26;
                i--;
                pictureBox9.Refresh();
                pictureBox9.Update();
            }
            if (i == 4 && x == 2)
            {
                letter3 = 26;
                i--;
                pictureBox8.Refresh();
                pictureBox8.Update();
            }
            if (i == 5 && x == 2)
            {
                letter4 = 26;
                i--;
                pictureBox7.Refresh();
                pictureBox7.Update();
            }
            if (i == 6 && x == 2)
            {
                letter5 = 26;
                i--;
                pictureBox6.Refresh();
                pictureBox6.Update();
            }

            //Row 3
            if (i == 2 && x == 3)
            {
                letter1 = 26;
                i--;
                pictureBox15.Refresh();
                pictureBox15.Update();
            }
            if (i == 3 && x == 3)
            {
                letter2 = 26;
                i--;
                pictureBox14.Refresh();
                pictureBox14.Update();
            }
            if (i == 4 && x == 3)
            {
                letter3 = 26;
                i--;
                pictureBox13.Refresh();
                pictureBox13.Update();
            }
            if (i == 5 && x == 3)
            {
                letter4 = 26;
                i--;
                pictureBox12.Refresh();
                pictureBox12.Update();
            }
            if (i == 6 && x == 3)
            {
                letter5 = 26;
                i--;
                pictureBox11.Refresh();
                pictureBox11.Update();
            }

            //Row 4
            if (i == 2 && x == 4)
            {
                letter1 = 26;
                i--;
                pictureBox20.Refresh();
                pictureBox20.Update();
            }
            if (i == 3 && x == 4)
            {
                letter2 = 26;
                i--;
                pictureBox19.Refresh();
                pictureBox19.Update();
            }
            if (i == 4 && x == 4)
            {
                letter3 = 26;
                i--;
                pictureBox18.Refresh();
                pictureBox18.Update();
            }
            if (i == 5 && x == 4)
            {
                letter4 = 26;
                i--;
                pictureBox17.Refresh();
                pictureBox17.Update();
            }
            if (i == 6 && x == 4)
            {
                letter5 = 26;
                i--;
                pictureBox16.Refresh();
                pictureBox16.Update();
            }

            //Row 5
            if (i == 2 && x == 5)
            {
                letter1 = 26;
                i--;
                pictureBox25.Refresh();
                pictureBox25.Update();
            }
            if (i == 3 && x == 5)
            {
                letter2 = 26;
                i--;
                pictureBox24.Refresh();
                pictureBox24.Update();
            }
            if (i == 4 && x == 5)
            {
                letter3 = 26;
                i--;
                pictureBox23.Refresh();
                pictureBox23.Update();
            }
            if (i == 5 && x == 5)
            {
                letter4 = 26;
                i--;
                pictureBox22.Refresh();
                pictureBox22.Update();
            }
            if (i == 6 && x == 5)
            {
                letter5 = 26;
                i--;
                pictureBox21.Refresh();
                pictureBox21.Update();
            }
        }
    }
}
