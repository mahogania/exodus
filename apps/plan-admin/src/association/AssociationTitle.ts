import { Association as TAssociation } from "../api/association/Association";

export const ASSOCIATION_TITLE_FIELD = "id";

export const AssociationTitle = (record: TAssociation): string => {
  return record.id?.toString() || String(record.id);
};
