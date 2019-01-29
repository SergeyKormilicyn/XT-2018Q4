function deleteChars(){
var str = document.getElementById("text1").value;
var spl;
var letters = ["?", "!", ":", ";", ",", ".", " ", "\t"];
for(let i = 1; i<str.length; i++)
{
    for(let j = 0; j<letters.length; j++)
    {
        if(str[i] == letters[j])
        {
           str = str.replace(str[i], " ");           
        }
    }   
}
spl = str.split(" ");
for(var i=0;i<spl.length;i++)
{
    for(var j=0;j<spl[i].length;j++)
    {
        var current_char = spl[i].charAt(j);
        
        for(var z=j;z<spl[i].length-1;z++)
        {
            if(current_char==spl[i].charAt(z+1))
            {
              str = str.split(current_char).join("");
            }
        }
    }
}
document.getElementById("text2").value = str;
}
