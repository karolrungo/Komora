function [result] = ISE(error, time)
result =0 ;
skaler = 100;
 
error = error ./ skaler;

     for i = 1:length(error)-1
         dt = time(i+1)-time(i);
         result = result + power(error(i),2)*dt;
     end
    
end