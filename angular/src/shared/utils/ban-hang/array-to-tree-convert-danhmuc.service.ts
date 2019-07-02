import { Injectable } from '@angular/core';
import * as _ from 'lodash';
import { ClassGetter } from '@angular/compiler/src/output/output_ast';

@Injectable()
export class ArrayToTreeConverterDanhMucService {

    createTree(array: any[], parentIdProperty, idProperty, parentIdValue, childrenProperty: string, fieldMappings): any {
        console.log(array);
        let tree = [];
        console.log(parentIdProperty);
        console.log(parentIdValue);
        let nodes = _.filter(array, [parentIdProperty, parentIdValue]);
        console.log(nodes);
        _.forEach(nodes, node => {
            let newNode = {
                data: node
            };

            this.mapFields(node, newNode, fieldMappings);

            newNode[childrenProperty] = this.createTree(
                array,
                parentIdProperty,
                idProperty,
                node[idProperty],
                childrenProperty,
                fieldMappings
            );

            tree.push(newNode);
        });
console.log(tree);
        return tree;
    }

    mapFields(node, newNode, fieldMappings): void {
        _.forEach(fieldMappings, fieldMapping => {
            if (!fieldMapping['target']) {
                return;
            }

            if (fieldMapping.hasOwnProperty('value')) {
                newNode[fieldMapping['target']] = fieldMapping['value'];
            } else if (fieldMapping['source']) {
                newNode[fieldMapping['target']] = node[fieldMapping['source']];
            } else if (fieldMapping['targetFunction']) {
                newNode[fieldMapping['target']] = fieldMapping['targetFunction'](node);
            }
        });
    }
}
