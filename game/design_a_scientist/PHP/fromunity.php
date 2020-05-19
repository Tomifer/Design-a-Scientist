<?php
	$textColor = $_POST["color"];
	$textHair = $_POST["hair"];
	$textShirt = $_POST["shirt"];
	$textItem = $_POST["item"];
	$textDate = $_POST["date"];
	
	if ($textColor != "")
	{
		echo("Data recieved");
		echo("Field 1:" . $textColor);
		echo("Field 2:" . $textHair);
		echo("Field 3:" . $textShirt);
		echo("Field 4:" . $textItem);
		echo("Field 5:" . $textDate);
		$file = fopen("data.csv", "a");
		fwrite($file, "\n" . $textColor . ",");
		fwrite($file, $textHair . ",");
		fwrite($file, $textShirt . ",");
		fwrite($file, $textItem . ",");
		fwrite($file, $textDate);
		fclose($file);
	} else 
	{
		echo("Data sending failed");
	}
?>