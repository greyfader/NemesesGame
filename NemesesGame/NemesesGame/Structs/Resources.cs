﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemesesGame
{
    public struct Resources
    {
        int gold;
        int wood;
        int stone;
        int mithril;

        public int Gold { get { return gold; } set { gold = value; } }
        public int Wood { get { return wood; } set { wood = value; } }
        public int Stone { get { return stone; } set { stone = value; } }
        public int Mithril { get { return mithril; } set { mithril = value; } }

        public Resources(int thisGold, int thisWood, int thisStone, int thisMithril)
        {
            gold = thisGold;
            wood = thisWood;
            stone = thisStone;
            mithril = thisMithril;
        }

        public static Resources Zero()
        {
            return new Resources(0, 0, 0, 0);
        }

        public int GetThisResource(ResourceType resourceType)
        {
            switch (resourceType)
            {
                case ResourceType.Gold:
                    return gold;
                case ResourceType.Wood:
                    return wood;
                case ResourceType.Stone:
                    return stone;
                case ResourceType.Mithril:
                    return mithril;
                default:
                    return 0;
            }
        }

        public void Add (ResourceType rType, int value)
        {
            switch (rType)
            {
                case ResourceType.Gold:
                    gold += value;
                    break;
                case ResourceType.Wood:
                    wood += value;
                    break;
                case ResourceType.Stone:
                    stone += value;
                    break;
                case ResourceType.Mithril:
                    mithril += value;
                    break;
            }
        }

        public static Resources operator +(Resources a, Resources b)
        {
            Resources c = new Resources();
            c.gold = a.gold + b.gold;
            c.wood = a.wood + b.wood;
            c.stone = a.stone + b.stone;
            c.mithril = a.mithril + b.mithril;

            return c;
        }

        public static Resources operator -(Resources a, Resources b)
        {
            Resources c = new Resources();
            c.gold = a.gold - b.gold;
            c.wood = a.wood - b.wood;
            c.stone = a.stone - b.stone;
            c.mithril = a.mithril - b.mithril;

            return c;
        }

        public static bool operator ==(Resources a, Resources b)
        {
            if( a.Gold == b.Gold 
                && a.Wood == b.Wood
                && a.Stone == b.Stone
                && a.Mithril == b.Mithril) { return true; }
            else { return false; }
        }

        public static bool operator !=(Resources a, Resources b)
        {
            return !(a == b);
        }

		public static bool operator <(Resources a, Resources b)
		{
			if (a.Gold < b.Gold
				&& a.Wood < b.Wood
				&& a.Stone < b.Stone
				&& a.Mithril < b.Mithril) { return true; }
			else { return false; }
		}

        public static bool operator <=(Resources a, Resources b)
        {
            if (a.Gold <= b.Gold
                && a.Wood <= b.Wood
                && a.Stone <= b.Stone
                && a.Mithril <= b.Mithril) { return true; }
            else { return false; }
        }

        public static bool operator >(Resources a, Resources b)
		{
			if (a.Gold > b.Gold
				&& a.Wood > b.Wood
				&& a.Stone > b.Stone
				&& a.Mithril > b.Mithril) { return true; }
			else { return false; }
		}

        public static bool operator >=(Resources a, Resources b)
        {
            if (a.Gold >= b.Gold
                && a.Wood >= b.Wood
                && a.Stone >= b.Stone
                && a.Mithril >= b.Mithril) { return true; }
            else { return false; }
        }
	}
}
