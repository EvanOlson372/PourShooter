// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

Console.WriteLine("Shooters?");
string response = Console.ReadLine();

while (!IsValid(response))
{
    Console.WriteLine("Please Enter valid response.");
    Console.WriteLine("Valid Reponses:");
    Console.WriteLine("OH HELL YES!");

    Console.Write("Response: ");
    response = Console.ReadLine();
}


PourShooter();

Console.Read();


bool IsValid(string input)
{
    return input != "OH HELL YES!" ? false : true;
}

void PourShooter()
{
    Console.WriteLine("                                                                                \r\n                                                                                \r\n                                                                                \r\n                                                                                \r\n                                                                                \r\n                                                                                \r\n                                                                                \r\n                                                                          ,#@@@@\r\n                                      .**/,/*/,. *. *  ,       .,.,,*(#(**//((((\r\n                                      ,*//##*/(*((///(##%(%##(////((((//*,...,,*\r\n                                     ,  .,,(  , ,  ,* /.....         .,,,,****//\r\n                                     ,  .. *  ..(**(,/&(((*..     ..,,*,,,,.....\r\n                                     /(/*,.,    ,   . / .         ..,,*,,,,,,,..\r\n                                   (/,*/*,,* .  ,    .* , .........,*****,,,,,,,\r\n                                    /##,((((,/*/*,.,*(*.***/****,,,*((//****,,,,\r\n                               .    .  ..,(#/((#*. (#& ./(/########%&%#((///****\r\n                             ,/   *,                           .,(##%&&&%%#((((/\r\n                            (     .                                   ,(#(%%(#(%\r\n                           /     /,                                             \r\n                          .    #...                                             \r\n                          .   ,*%                                               \r\n                         #    ,.                                                \r\n                        *    .                                                  \r\n                        .    .                                                  \r\n                       .   .**                                                  \r\n                       .   . *                                                  \r\n                          . ,/                                                  \r\n                       .   **.                                                  \r\n                      /    ,                                                    \r\n                         * .                                                    \r\n            .////*///////#******/(#(//****//.                                   \r\n            .%(*,...*.. .&   ,(&%(/(%(/.,,((*                                   \r\n             (/(*#* ,.**@..(#%%(////,.*(.//(.                                   \r\n             /(%((%(/#((*((/###%#%#/((#(#%#(.                                   \r\n             ,*/,...(*(****/.,*.,*/...,,.,*(                                    \r\n              * *  .*#/./(**#//,/,(..,....*,                                    \r\n              .*#%,**.////*.,*.*.*/..**,#,%                                     \r\n               */@.,/*(//*(.&#((....,*,/(#                                      \r\n               *(*%/(#%##(#((#/,*.,,,,,#*##                                     \r\n               ,*/@.((/*(((//(,.,,,,,,,#/&/                                     \r\n               ./,/#**/(###(,(,#(//*///(/#                                      \r\n                (..&#**///******//#((/#,##                                      \r\n                (/ .  ........    .,.,,,#%                                      \r\n                *(........       .,*.,,*#&                                      \r\n                ,*.........      .,/.,,/%(                                      \r\n                ,%#**//(#%#%%%%####%*/#%#.                                      \r\n                ,*                ., ...//                                      \r\n                ,,                 .   .**                                      \r\n");
}



