using Godot;
using System;

namespace Project{
	public partial class CharacterStats : Node
	{
		// 属性最大值
		public float max_val_health = 100f;
		public float max_val_spirit = 50f;
		public float max_val_stagger = 5f;
		public float max_val_break = 50f;
		//属性值
		public float val_health = 0f;
		public float val_spirit = 0f;
		public float val_stagger = 0f;
		public float val_break = 0f;
		
		//属性变动
		public void changeStatsByEnum(ProjectEnum stats, float changeVal,bool isIncreasing){
			//判断是上升还是下降
			if(!isIncreasing) {
				changeVal = 0 - changeVal;
			}
			switch(stats){
				//属性值更新
				case ProjectEnum.HEALTH:
					val_health = val_health + changeVal < 0 ? 0 : val_health + changeVal;
					break;
				case ProjectEnum.SPIRIT:
					val_spirit = val_spirit + changeVal < 0 ? 0 : val_spirit + changeVal;
					break;
				case ProjectEnum.STAGGER:
					val_stagger = val_stagger + changeVal < 0 ? 0 : val_stagger + changeVal;
					break;
				case ProjectEnum.BREAK:
					val_break = val_break + changeVal < 0 ? 0 : val_break + changeVal;
					break;
				//上限值更新
				case ProjectEnum.MAXHEALTH:
					val_health = max_val_health + changeVal < 0 ? 0 : max_val_health + changeVal;
					break;
				case ProjectEnum.MAXSPIRIT:
					val_spirit = max_val_spirit + changeVal < 0 ? 0 : max_val_spirit + changeVal;
					break;
				case ProjectEnum.MAXSTAGGER:
					val_stagger = max_val_stagger + changeVal < 0 ? 0 : max_val_stagger + changeVal;
					break;
				case ProjectEnum.MAXBREAK:
					val_break = max_val_break + changeVal < 0 ? 0 : max_val_break + changeVal;
					break;
				default:
					break;
			}
		}

		public override void _Ready()
		{
			GD.Print("Hello, World from C#!");
		}
	}
}
