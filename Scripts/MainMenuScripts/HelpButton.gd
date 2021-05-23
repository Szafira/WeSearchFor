extends Button

func _on_HelpButton_pressed():
	if ($Instr.visible):
		$Instr.visible = false
	else:
		$Instr.visible = true
