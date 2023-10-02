class BaseCaseOperations:
    def __init__(self):
        pass

    def convert_to(self, input_string):
        pass

    def is_valid(self, input_string):
        pass


# camelcase
class CamelCase(BaseCaseOperations):
    def __init__(self):
        super().__init__()

    def convert_to(self, input_string):
        words = input_string.split()
        camel_case_str = words[0].lower()
        for word in words[1:]:
            camel_case_str += word.capitalize()
        return camel_case_str

    def is_valid(self, input_string):
        if not input_string:
            return False
        if not input_string[0].islower():
            return False
        for i in range(1, len(input_string)):
            if input_string[i].isspace():
                return False
        return True


class PascalCase(BaseCaseOperations):
    def __init__(self):
        super().__init__()

    def convert_to(self, input_string):
        words = input_string.split()
        pascal_case_str = ''.join(word.capitalize() for word in words)
        return pascal_case_str

    def is_valid(self, input_string):
        if not input_string:
            return False
        if not input_string[0].isupper():
            return False
        for i in range(1, len(input_string)):
            if input_string[i].isspace():
                return False
            if input_string[i].isupper() and input_string[i-1].isupper():
                return False


# snake_case
class SnakeCase(BaseCaseOperations):
    def __init__(self):
        super().__init__()

    def convert_to(self, input_string):
        words = input_string.split()
        snake_case_str = '_'.join(word.lower() for word in words)
        return snake_case_str

    def is_valid(self, input_string):
        if not input_string:
            return False
        if input_string[0] == '_' or input_string[-1] == '_':
            return False
        if '__' in input_string:
            return False
        if any(char.isupper() for char in input_string):
            return False
        if ' ' in input_string:
            return False
        return True


# kebab-case
class KebabCase(BaseCaseOperations):
    def __init__(self):
        super().__init__()

    def convert_to(self, input_string):
        words = input_string.split()
        kebab_case_str = '-'.join(word.lower() for word in words)
        return kebab_case_str

    def is_valid(self, input_string):
        if not input_string:
            return False
        if input_string[0] == '-' or input_string[-1] == '-':
            return False
        if '--' in input_string:
            return False
        if any(char.isupper() for char in input_string):
            return False
        if ' ' in input_string:
            return False
        return True
