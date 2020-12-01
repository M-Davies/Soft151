<!DOCTYPE html>
<html>

<head>
	<title>Index</title>
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>

<body onload="drawcircle();">

	<ul class="nav justify-content-end">
		<li class="nav-item">
			<a class="nav-link active" href="#">Active</a>
		</li>
		<li class="nav-item">
    		<a class="nav-link" href="#">Link</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Link</a>
		</li>
		<li class="nav-item">
			<a class="nav-link disabled" href="#" tabindex="-1" aria-disabled="true">Disabled</a>
		</li>
	</ul>

	<div class="container">
		<div class="row">
			<div class="col jumbotron">
				<h5>Linked Accounts</h5>
				<hr class="my-4">

				<form action="http://localhost/203/index.php" method="post">
				<div id="fblink" class="input-group mb-3" action="index.php?val=1" method="post">
						<div class="input-group-prepend">
							<span class="input-group-text" id="inputGroup-sizing-default">https://www.facebook.com/</span>
						</div>
						<input type="text" name="test123" value="example.profile" class="form-control" >
				</div>
				<!--<div id="twitter" class="input-group mb-3">
						<div class="input-group-prepend">
							<span class="input-group-text" id="inputGroup-sizing-default">https://www.twitter.com/</span>
						</div>
						<input type="text" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default">
				</div>-->
				<input type="submit" method="post" value="Search" class="btn btn-danger"/>


			</div>
			<div class="col jumbotron">
				<h5>Confidence Rating</h5>
				<hr class="my-4">
				<canvas id="circle"  width="200" height="200"/>
			</div>
		</div>
		<div class="row">
			<div class="col">
			<p id="test">
			<?php
				//if (isset($_POST["submit"]) && !empty($_POST["submit"]))
					if(isset($_POST['test123'])){
						$command = "python test.py ". $_POST['test123'];
						echo "running command: python test.py ". $_POST['test123']."<br>";

						$output = shell_exec($command); //BIG SECURITY FLAW GOES HERE
						echo "\/---------\/<br>";
						echo $output;
					}
			?>
			<!--//BOXES FOR ACCOUNT LINKING-->
			</div>
			<div class="col">
			<!--//JAVASCRIPT CIRCLE GOES HERE-->
			<!--<canvas id="circle"  width="200" height="200"/>-->
			</div>
		</div>
	</div>
<script>
	function drawcircle(){
		var canvas = document.getElementById('circle');
		if(canvas.getContext){
			var ctx = canvas.getContext('2d');
			var X = canvas.width /2;
			var Y = canvas.height /2;
			var R = 60;
			ctx.beginPath()
			ctx.arc(X, Y, R, 0, 2 * Math.PI, false);
			ctx.lineWidth = 20;
			ctx.strokeStyle = '#FF0000';
			ctx.stroke();
		}
	}
</script>

<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

<style>
body{
	background-color:#ECE5CE
}
.nav{
	background-color:#F1D4AF
}
.nav-link{
	color:#E08E79
}
</style>

</body>

</html>