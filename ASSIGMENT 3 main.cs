
    def display_menu():
    print("1. Sum Tuples")
    print("2. Export JSON")
    print("3. Import JSON")
    print("4. Exit")

def main():
    while True:
        display_menu()
        choice = input("Enter a choice: ")

        if choice == '1':
            try:
                tup1 = tuple(map(int, input("Enter the elements of the first tuple separated by spaces: ").split()))
                tup2 = tuple(map(int, input("Enter the elements of the second tuple separated by spaces: ").split()))
                result = sum_tuples(tup1, tup2)
                print("Result:", result)
            except ValueError as e:
                print("Error:", e)

        elif choice == '2':
            try:
                filename = input("Enter the filename for JSON export: ")
                data_dict = { }
keys = input("Enter keys for the dictionary separated by spaces: ").split()
                values = input("Enter corresponding values for the dictionary separated by spaces: ").split()
                data_dict = dict(zip(keys, values))
                export_json(data_dict, filename)
                print("Data exported to JSON successfully.")
            except Exception as e:
                print("Error:", e)

        elif choice == '3':
            try:
                filename = input("Enter the filename for JSON import: ")
                data_dict = import_json(filename)
                print("Data imported from JSON:", data_dict)
            except Exception as e:
                print("Error:", e)

        elif choice == '4':
            print("Exiting the program.")
            break

        else:
            print("Invalid choice. Please try again.")

if __name__ == "__main__":
    main()