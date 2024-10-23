import { ObjectType as TObjectType } from "../api/objectType/ObjectType";

export const OBJECTTYPE_TITLE_FIELD = "id";

export const ObjectTypeTitle = (record: TObjectType): string => {
  return record.id?.toString() || String(record.id);
};
