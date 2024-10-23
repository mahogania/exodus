import { PropertyType as TPropertyType } from "../api/propertyType/PropertyType";

export const PROPERTYTYPE_TITLE_FIELD = "id";

export const PropertyTypeTitle = (record: TPropertyType): string => {
  return record.id?.toString() || String(record.id);
};
