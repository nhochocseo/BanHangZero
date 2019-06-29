export interface Category {
    id: number;
    parentId: number; // id danh mục cha
    name: string;
    url: string;
    describe: string;
}
