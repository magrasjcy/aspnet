@using PizzaZ.Order.Bean;
@model Order

@{
     Layout=null;
}
<!DOCTYPE html>
<html>
<head>
   <meta name="viewport" content="width=device-width" />
   <title></title>
</head>
<body>
     @{
	<input type=checkbox name=":@Model.Name"/>
	<input type=checkbox name=":@Model.Name"/>	
     }
</body>
</html>
