extends CollisionShape2D

func _on_CollisionDetector_body_shape_entered(_body_id, _body,_body_shape, _local_shape):
	get_tree().reload_current_scene()


func _on_Portal1_body_shape_entered(_body_id, _body,_body_shape, _local_shape):
	get_tree().change_scene("res://Scenes/Level2.tscn")


func _on_Portal2_body_shape_entered(_body_id, _body,_body_shape, _local_shape):
	get_tree().change_scene("res://Scenes/Level3.tscn")


func _on_Portal3_body_shape_entered(_body_id, _body,_body_shape, _local_shape):
	get_tree().change_scene("res://Scenes/Level4.tscn")


func _on_Portal4_body_shape_entered(_body_id, _body,_body_shape, _local_shape):
	get_tree().change_scene("res://Scenes/Level5.tscn")


func _on_Portal5_body_shape_entered(body_id, body, body_shape, local_shape):
	get_tree().change_scene("res://Scenes/ScenePicker.tscn")
