import { AssociationType as TAssociationType } from "../api/associationType/AssociationType";

export const ASSOCIATIONTYPE_TITLE_FIELD = "id";

export const AssociationTypeTitle = (record: TAssociationType): string => {
  return record.id?.toString() || String(record.id);
};
