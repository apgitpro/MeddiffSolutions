input={'Input.txt': 'Randy', 'Code.py': 'Stan', 'Output.txt': 'Randy'}
output={}

for k,v in input.items():
	output[v]=[k] if v not in output.keys() else output[v] + [k]
print(output)

