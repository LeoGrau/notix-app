export function defaultValidator(fieldName: string) {
  return (value: any) => {
    if (!value) {
      return `${fieldName} is required`
    }
    return true
  }
}