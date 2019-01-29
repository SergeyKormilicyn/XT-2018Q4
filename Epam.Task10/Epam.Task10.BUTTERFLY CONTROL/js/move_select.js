var list1 = document.getElementById("left");
var list2 = document.getElementById("right");
function one_move(name)
{
var my_element = document.getElementById(name);
var my_index = my_element.selectedIndex;	

		if(name=="left")
		{
			if(my_index==-1)
			{
				alert("element isn't choosen!!!!!")
			}
			else
			{
				var newElement = my_element[my_index].cloneNode(true);
				list1.removeChild(my_element[my_index]);
				list2.append(newElement);
			}
		}
		if(name=="right")
		{
			if(my_index==-1)
			{
				alert("element isn't choosen!!!!!")
			}
				else
				{
						var newElement = my_element[my_index].cloneNode(true);
						list2.removeChild(my_element[my_index]);
						list1.append(newElement);
				}
		}
	}
	function all_move(name)
	{
		my_element = document.getElementById(name);
		if(name == "left")
		{
			while(my_element.length > 0)
			{
				var newElement = my_element[0].cloneNode(true);
				list1.removeChild(my_element[0]);
				list2.append(newElement);
			}
			
		}
		else if(name == "right")
		{
		while(my_element.length > 0)
			{
				var newElement = my_element[0].cloneNode(true);
				list2.removeChild(my_element[0]);
				list1.append(newElement);
			}
		}
	}