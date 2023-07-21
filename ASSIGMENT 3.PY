import json

def sum_tuples(tup1, tup2):
    if len(tup1) != len(tup2):
        raise ValueError("Input tuples must be of the same length.")
    return tuple(x + y for x, y in zip(tup1, tup2))

def export_json(data_dict, filename):
    with open(filename, 'w') as file:
        json.dump(data_dict, file)

def import_json(filename):
    with open(filename, 'r') as file:
        data_dict = json.load(file)
    return data_dict