extends Button



func _on_OptionButton_pressed():
	if ($ButtonStart.visible):
		$ButtonStart.visible = false
	else:
		$ButtonStart.visible = true
		
	if ($ButtonExit.visible):
		$ButtonExit.visible = false
	else:
		$ButtonExit.visible = true
		
	if ($LevelPicker.visible):
		$LevelPicker.visible = false
	else:
		$LevelPicker.visible = true
		
	if ($mainMenuBackground.visible):
		$mainMenuBackground.visible = false
	else:
		$mainMenuBackground.visible = true
	
	if ($HelpButton.visible):
		$HelpButton.visible = false
	else:
		$HelpButton.visible = true
