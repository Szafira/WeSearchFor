extends Control

func _on_Portal1_body_shape_entered(_body_id, _body, _body_shape, _local_shape):
	emit_signal("enable")
