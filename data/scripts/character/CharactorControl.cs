using Godot;
using System;

namespace Project{
	public partial class CharactorControl : Node3D
	{
		float RayLength = 1000f;

		public override void _Ready(){
			GD.Print("move component ready");
		}
		
		public override void _Input(InputEvent @event)
		{
			if (@event is InputEventMouseButton mouseButton && mouseButton.ButtonIndex == MouseButton.Left)
			{
				//获取专注摄像机
				Camera3D CameraFocus = GetNode<Camera3D>("CameraFocus");
				var spaceState = GetWorld3D().DirectSpaceState;
				//射线两端获取
				var from = CameraFocus.ProjectRayOrigin(mouseButton.Position);
				var to = from + CameraFocus.ProjectRayNormal(mouseButton.Position) * RayLength;
				var query = PhysicsRayQueryParameters3D.Create(from, to);
    			query.CollideWithAreas = true;
    			var result = spaceState.IntersectRay(query); // 发射射线并获取结果
			}
		}
	}

}
