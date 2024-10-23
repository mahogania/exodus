import { Object as TObject } from "../api/object/Object";

export const OBJECT_TITLE_FIELD = "id";

export const ObjectTitle = (record: TObject): string => {
  return record.id?.toString() || String(record.id);
};
