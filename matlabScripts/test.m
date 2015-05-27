function [result] = test(error, timeDeltas);
result = 0;

time = timeDeltas(1) : 0.1 : timeDeltas(length(timeDeltas));
SignalInterp = interp1(timeDeltas, error, time);

for i = 1 : length(time)-1
	dt = time(i+1)-time(i);
    result = result + power(SignalInterp(i),2)*dt;
end
